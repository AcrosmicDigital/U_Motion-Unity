using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U.Motion
{
    public abstract class ImpulseAnimatorCore : MonoBehaviour
    {


        public ImpulseAnimatorParams config { get; private set; } = new ImpulseAnimatorParams();
        public float preferedValue { get; private set; }
        public bool IsSet { get; private set; } = false;  // When this is true the animation will start

        private float currentValue = 0;

        public Exception Error { get; private set; } = null;  // If the animation produce an error

        public bool IsPaused { get; private set; } = true;  // If the animation is completed or an error was thrown



        protected virtual void DoImpulse(float targetValue, float duration, float delay = 0, float timeToReachImpulse = 0, float timeToDeleteImpulse = 0)
        {

            if (!this.enabled || !gameObject.activeSelf)
            {
                Debug.LogError("Cant do impulse because Gameovject or Behaviour are inactive");
                return;
            }

            StartCoroutine(ImpulseCorroutine(targetValue, duration, delay, timeToReachImpulse, timeToDeleteImpulse));

        }


        private void Update()
        {
            // Wait for the animation to be set
            if (!IsSet || IsPaused)
                return;

            var updateValue = ((int)(currentValue * 1000)) / 1000f;

            if (updateValue > config.maxValue)
                updateValue = config.maxValue;

            if (updateValue < config.minValue)
                updateValue = config.minValue;


            try
            {
                if (config.fillMode != Utween.FillMode.None)
                    OnUpdate(updateValue);
            }
            catch (Exception e)
            {
                Error = e;
                IsPaused = false;
                Debug.LogException(Error);

                this.enabled = false;

            }

        }


        IEnumerator ImpulseCorroutine(float targetValue, float duration, float delay, float timeToReachImpulse, float timeToDeleteImpulse)
        {
            float time = 0;
            float lValue;
            float cValue;

            if (delay > 0)
            {
                while (time < delay)
                {
                    AddTime(ref time);
                    yield return null;
                }
                time -= delay;
            }


            lValue = 0;
            
            if(timeToReachImpulse > 0)
            {
                do
                {
                    AddTime(ref time);

                    cValue = config.timeCurve.Evaluate(time / timeToReachImpulse);
                    currentValue += (cValue - lValue) * targetValue;
                    lValue = cValue;

                    yield return null;
                }
                while (time < timeToReachImpulse);
                time -= timeToReachImpulse;
            }
            else
            {
                currentValue += targetValue;
            }


            if (duration > 0)
            {
                while (time < duration)
                {
                    AddTime(ref time);
                    yield return null;
                }
                time -= duration;
            }

            lValue = 0;
            if (timeToDeleteImpulse > 0)
            {
                do
                {
                    AddTime(ref time);

                    cValue = config.timeCurve.Evaluate(time / timeToDeleteImpulse);
                    currentValue -= (cValue - lValue) * targetValue;
                    lValue = cValue;

                    yield return null;
                }
                while (time < timeToDeleteImpulse);
                time -= timeToDeleteImpulse;
            }
            else
            {
                currentValue -= targetValue;
            }
            
        }



        // Function to add the time to a counter, time or delaytime
        private void AddTime(ref float timeCounter)
        {
            if (config.timeMode == Utween.TimeMode.DeltaTime)
                timeCounter += Time.deltaTime;
            else
                timeCounter += Time.unscaledDeltaTime;
        }



        // Use this function from child classes to start the animation
        protected void Set(float preferedValue, ImpulseAnimatorParams animationParams)
        {
            if (animationParams != null)
                this.config = animationParams;

            currentValue = preferedValue;
            this.preferedValue = preferedValue;
            this.IsSet = true;
        }


        // The delegate that will run each frame
        protected abstract void OnUpdate(float currentValue);



        public virtual List<AnimationCurve> GetCurves()
        {
            try
            {
                return new List<AnimationCurve>
                {
                    config.timeCurve,
                };
            }
            catch (Exception)
            {
                return new List<AnimationCurve>();
            }

        }



        private void OnDestroy()
        {
            if (IsPaused)
                return;

            if (config.fillMode == Utween.FillMode.Backwards)
                OnUpdate(preferedValue);
            else if (config.fillMode == Utween.FillMode.Forwards)
                OnUpdate(preferedValue);
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

        public void Repeat()
        {
            StopAllCoroutines();
            OnUpdate(preferedValue);
            Error = null;
            currentValue = preferedValue;
        }


    }
}

