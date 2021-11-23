using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine.Events;

namespace U.Motion 
{

    // 



    public abstract class TimeAnimatorCore : MonoBehaviour, IAnimatorCore
    {
        // Properties

        public string animationName = "";
        public float duration = 2;
        public int iterations = 1;
        public float delay = 0;
        public bool playOnAwake = true;
        public bool allowUnexpectedEnd = true; // If true no error will be throw if animation is deleted
        public UAnimation.Direction direction = UAnimation.Direction.Normal;
        public UAnimation.FillMode fillMode = UAnimation.FillMode.Both;
        public TimeCurve timeCurve = TimeCurve.easeInOut;
        public UAnimation.TimeMode timeMode = UAnimation.TimeMode.UnscaledDeltaTime;
        public UAnimation.OnCompleteMode onCompleteMode = UAnimation.OnCompleteMode.Disable;
        public UnityEvent onComplete = new UnityEvent();

        // /Properties

        public int Progress 
        { 
            get {

                if (!delayCompleted) return (int)((time / delay) * 100);
                return (int)((time / duration) * 100);
            }
        }  
        public bool IsPaused { get; private set; } = false;  // If the animation is paused
        public Exception Error { get; private set; } = null;  // If the animation produce an error
        public bool IsCompleted { get; private set; } = false;  // If the animation is completed or an error was thrown

        private bool IsDestroyed = false;
        public bool isDestroyed => IsDestroyed;

        private float copletedPercentage = 0;  // Completed percentage of an animation iteration
        private float time = 0; // Current time elapsed
        private int completedIterations = 0; // Current completed iterations
        private bool delayCompleted = false;  // true when the delay is completed
        private TaskCompletionSource<bool> tks = new TaskCompletionSource<bool>();  // Task to wait for the animation
        private bool pausedBeforeStart = false;

        private void Start()
        {
            if(!pausedBeforeStart)
                IsPaused = !playOnAwake;
        }

        // Update is called once per frame
        void Update()
        {
            
            // Wait for the animation to be set
            if (IsPaused || IsCompleted)
                return;


            // Check for onCompleteMode 
            if (onCompleteMode == UAnimation.OnCompleteMode.Loop)
            {
                if (completedIterations > 1)
                    completedIterations = 0;
            }
            else
            {
                if (completedIterations >= iterations)
                {
                    IsCompleted = true;
                    SetFillMode();

                    if (!tks.Task.IsCompleted)
                        tks.SetResult(true);

                    if (onCompleteMode == UAnimation.OnCompleteMode.Disable)
                        this.enabled = false;
                    if (onCompleteMode == UAnimation.OnCompleteMode.Destroy)
                    {
                        
                        Destroy(this);
                    }

                    return;
                }
            }


            // If the start delay time is not completed return
            if (!delayCompleted)
            {
                if (time < delay)
                {
                    AddTime(ref time);
                    return;
                }
                else
                {
                    delayCompleted = true;
                    time -= delay;
                }
            }
            


            // Calc the completed percentage of the animation
            if(duration > 0)
            {
                if (direction == UAnimation.Direction.Reverse)
                    copletedPercentage = timeCurve.Evaluate((duration - time) / duration);

                else if (direction == UAnimation.Direction.Alternate)
                    if (completedIterations % 2 == 0)
                        copletedPercentage = timeCurve.Evaluate(time / duration);
                    else
                        copletedPercentage = timeCurve.Evaluate((duration - time) / duration);

                else if (direction == UAnimation.Direction.AlternateReverse)
                    if (completedIterations % 2 == 0)
                        copletedPercentage = timeCurve.Evaluate((duration - time) / duration);
                    else
                        copletedPercentage = timeCurve.Evaluate(time / duration);

                else //(config.direction == Utween.Direction.Normal)
                    copletedPercentage = timeCurve.Evaluate(time / duration);

            }
            else
            {
                copletedPercentage = 1;
            }


            // Run the OnUpdate Function
            try
            {
                if (fillMode != UAnimation.FillMode.None)
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
            while(time >= duration && i < 10000)
            {
                time -= duration;
                completedIterations++;
                i++;
            }
            AddTime(ref time);


        }

        // Function to add the time to a counter, time or delaytime
        private void AddTime(ref float timeCounter)
        {
            if (timeMode == UAnimation.TimeMode.DeltaTime)
                timeCounter += Time.deltaTime;
            else
                timeCounter += Time.unscaledDeltaTime;
        }

        // Toset the fillmode when animation is completed
        private void SetFillMode()
        {
            // Invoke the oncomplete event
            try
            {
                onComplete?.Invoke();
            }
            catch (Exception e)
            {
                Debug.LogError("U.Motion: onComplete event throw error, " + e);
            }

            if (Error != null)
                return;

            try
            {
                if (fillMode == UAnimation.FillMode.Backwards)
                    OnUpdate(0);
                else if (fillMode == UAnimation.FillMode.Forwards)
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

        // Actions when the component is destroyed
        private void OnDestroy()
        {
            IsDestroyed = true;

            if (IsCompleted)
                return;

            // Set error or resut if is allowed unexpected and
            if (!allowUnexpectedEnd)
            {
                IsCompleted = true;
                Error = new Exception("Component or GameObject was destroyed before animation completes");
                Debug.LogError(Error);

                if (!tks.Task.IsCompleted)
                    tks.SetException(Error);
            }

            // If object is destroyed before animation complete, Task will never end
            //else
            //{
            //    IsCompleted = true;

            //    if (!tks.Task.IsCompleted)
            //        tks.SetResult(true);
            //}

            
        }


        // The delegate that will run each frame
        protected abstract void OnUpdate(float copletedPercentage);


        // Function that use the custom inspector extension to display all the curves
        public abstract List<AnimationCurve> GetCurves();  

        // To Reset the animation
        public void Restart()
        {
            enabled = true;
            
            time = 0;
            completedIterations = 0;
            delayCompleted = false;
            IsCompleted = false;
            IsPaused = !playOnAwake;
            Error = null;

            if(tks.Task.IsCompleted)
                tks = new TaskCompletionSource<bool>();

        }

        // To Pause the animation
        public void Pause()
        {
            IsPaused = true;
            pausedBeforeStart = true;
        }

        // To resume the animation
        public void Play()
        {
            IsPaused = false;
            pausedBeforeStart = true;
        }


        // To early complete the anmation
        public void CompleteNow()
        {
            if (IsCompleted)
                return;

            if (onCompleteMode == UAnimation.OnCompleteMode.Loop)
                return;

            IsCompleted = true;

            SetFillMode();

            if (!tks.Task.IsCompleted)
                tks.SetResult(true);

            if (onCompleteMode == UAnimation.OnCompleteMode.Disable)
                this.enabled = false;
            if (onCompleteMode == UAnimation.OnCompleteMode.Destroy)
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

            while (!IsCompleted)
                yield return null;

            if (Error != null)
                throw new Exception();

        }


        public void DestroyAnimation()
        {
            // Set error or resut if is allowed unexpected and
            if (!allowUnexpectedEnd)
            {
                IsCompleted = true;
                Error = new Exception("Component or GameObject was destroyed before animation completes");
                Debug.LogError(Error);

                if (!tks.Task.IsCompleted)
                    tks.SetException(Error);
            }

            SetFillMode();

            if (!tks.Task.IsCompleted)
                tks.SetResult(true);

            Destroy(this);

        }

    }
}
