using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace U.Motion 
{

    // 



    public abstract class TimeAnimatorCore : MonoBehaviour
    {
        // Properties

        public TimeAnimationParams config = new TimeAnimationParams();  // The config of the animation


        public float Progress 
        { 
            get {
                if (config.onCompleteMode == Utween.OnCompleteMode.Loop)
                    return 0;
                else if (IsCompleted)
                    return 1;
                else
                    return ((completedIterations * config.duration) + copletedPercentage) / (config.iterations * config.duration);
            }
        }  // The completed percentage of the total of iterations, if is completed = 1, if is loop = 0
        public bool IsPaused { get; private set; } = false;  // If the animation is paused
        public Exception Error { get; private set; } = null;  // If the animation produce an error
        public bool IsCompleted { get; private set; } = false;  // If the animation is completed or an error was thrown
        public bool IsSet { get; private set; } = false;  // When this is true the animation will start

        private float copletedPercentage = 0;  // Completed percentage of an animation iteration
        private float time = 0; // Current time elapsed
        private int completedIterations = 0; // Current completed iterations
        private bool delayCompleted = false;  // true when the delay is completed
        private TaskCompletionSource<bool> tks = new TaskCompletionSource<bool>();  // Task to wait for the animation



        // Update is called once per frame
        void Update()
        {
            
            // Wait for the animation to be set
            if (!IsSet || IsPaused || IsCompleted)
                return;


            // Check for onCompleteMode 
            if (config.onCompleteMode == Utween.OnCompleteMode.Loop)
            {
                if (completedIterations > 1)
                    completedIterations = 0;
            }
            else
            {
                if (completedIterations >= config.iterations)
                {
                    IsCompleted = true;

                    SetFillMode();

                    if (!tks.Task.IsCompleted)
                        tks.SetResult(true);

                    if (config.onCompleteMode == Utween.OnCompleteMode.Disable)
                        this.enabled = false;
                    if (config.onCompleteMode == Utween.OnCompleteMode.Destroy)
                        Destroy(this);

                    return;
                }
            }


            // If the start delay time is not completed return
            if (!delayCompleted)
            {
                if (time < config.delay)
                {
                    AddTime(ref time);
                    return;
                }
                else
                {
                    delayCompleted = true;
                    time -= config.delay;
                    Debug.Log("End delay DelayCount for " + gameObject.name);
                }
            }
            


            // Calc the completed percentage of the animation
            if(config.duration > 0)
            {
                if (config.direction == Utween.Direction.Reverse)
                    copletedPercentage = config.timingCurve.Evaluate((config.duration - time) / config.duration);

                else if (config.direction == Utween.Direction.Alternate)
                    if (completedIterations % 2 == 0)
                        copletedPercentage = config.timingCurve.Evaluate(time / config.duration);
                    else
                        copletedPercentage = config.timingCurve.Evaluate((config.duration - time) / config.duration);

                else if (config.direction == Utween.Direction.AlternateReverse)
                    if (completedIterations % 2 == 0)
                        copletedPercentage = config.timingCurve.Evaluate((config.duration - time) / config.duration);
                    else
                        copletedPercentage = config.timingCurve.Evaluate(time / config.duration);

                else //(config.direction == Utween.Direction.Normal)
                    copletedPercentage = config.timingCurve.Evaluate(time / config.duration);

            }
            else
            {
                copletedPercentage = 1;
            }


            // Run the OnUpdate Function
            try
            {
                if (config.fillMode != Utween.FillMode.None)
                    OnUpdate(copletedPercentage);
            }
            catch (Exception e)
            {
                Error = e;
                IsCompleted = true;
                Debug.LogException(Error);

                if (!tks.Task.IsCompleted)
                    tks.SetException(e);

                this.enabled = false;

            }


            // Add the time
            int i = 0;
            while(time >= config.duration && i < 10000)
            {
                time -= config.duration;
                completedIterations++;
                i++;
            }
            AddTime(ref time);


        }

        // Function to add the time to a counter, time or delaytime
        private void AddTime(ref float timeCounter)
        {
            if (config.timeMode == Utween.TimeMode.DeltaTime)
                timeCounter += Time.deltaTime;
            else
                timeCounter += Time.unscaledDeltaTime;
        }

        // Toset the fillmode when animation is completed
        private void SetFillMode()
        {
            if (Error != null)
                return;

            try
            {
                if (config.fillMode == Utween.FillMode.Backwards)
                    OnUpdate(0);
                else if (config.fillMode == Utween.FillMode.Forwards)
                    OnUpdate(1);
            }
            catch (Exception e)
            {
                Error = e;
                IsCompleted = true;
                Debug.LogError(Error);

                if (!tks.Task.IsCompleted)
                    tks.SetException(e);

                this.enabled = false;
            }


        }

        // Use this function from child classes to start the animation
        protected void Set(TimeAnimationParams animationParams)
        {
            if (animationParams != null)
                this.config = animationParams;

            this.IsSet = true;
            IsPaused = !config.playOnAwake;
        }

        // Actions when the component is destroyed
        private void OnDestroy()
        {
            if (IsCompleted || !IsSet)
                return;

            // Set error or resut if is allowed unexpected and
            if (!config.allowUnexpectedEnd)
            {
                IsCompleted = true;
                Error = new Exception("Component or GameObject was destroyed before animation completes");
                Debug.LogError(Error);

                if (!tks.Task.IsCompleted)
                    tks.SetException(Error);
            }
            else
            {
                IsCompleted = true;

                if (!tks.Task.IsCompleted)
                    tks.SetResult(true);
            }

            
        }


        // The delegate that will run each frame
        protected abstract void OnUpdate(float copletedPercentage);


        // Function that use the custom inspector extension to display all the curves
        public abstract List<AnimationCurve> GetCurves();  

        // To Reset the animation
        public void Repeat()
        {
            this.enabled = true;
            
            time = 0;
            completedIterations = 0;
            delayCompleted = false;
            IsCompleted = false;
            IsPaused = !config.playOnAwake;
            Error = null;

            if(tks.Task.IsCompleted)
                tks = new TaskCompletionSource<bool>();

        }

        // To Pause the animation
        public void Pause()
        {
            IsPaused = true;
        }

        // To resume the animation
        public void Resume()
        {
            IsPaused = false;
        }


        // To early complete the anmation
        public void CompleteNow()
        {
            if (IsCompleted || !IsSet)
                return;

            if (config.onCompleteMode == Utween.OnCompleteMode.Loop)
                return;

            IsCompleted = true;

            SetFillMode();

            if (!tks.Task.IsCompleted)
                tks.SetResult(true);

            if (config.onCompleteMode == Utween.OnCompleteMode.Disable)
                this.enabled = false;
            if (config.onCompleteMode == Utween.OnCompleteMode.Destroy)
                Destroy(this);

            return;
        }



        


        // Function to get a Task to wait for animation completes or throw error
        public Task Task()
        {
            return tks.Task;
        }

        // Function to get a Coroutine to wait for animation completes or throw error
        public IEnumerator Coroutine()
        {

            while (!IsCompleted && IsSet)
                yield return null;

            if (Error != null)
                throw new Exception();

        }


    }
}
