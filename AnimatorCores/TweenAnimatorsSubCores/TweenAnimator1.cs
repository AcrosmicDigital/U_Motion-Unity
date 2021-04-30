using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace U.Motion
{
    public abstract class TweenAnimator<TValue> : TimeAnimatorCore
    {
        
        public KeyFramesCurve<TValue> keysCurve; // Values that the animation will take in the curve

        public Action<TValue> animate;


        public void Set(
            Action<TValue> animate,
            KeyFramesCurve<TValue> keysCurve,
            TimeAnimationParams animationParams = null
            )
        {
            
            this.animate = animate;
            this.keysCurve = keysCurve;

            base.Set(animationParams);
        }


        protected override void OnUpdate(float copletedPercentage)
        {
            animate?.Invoke(keysCurve.Evaluate(copletedPercentage));
        }


        public override List<AnimationCurve> GetCurves()
        {
            try
            {
                return new List<AnimationCurve>
                {
                    config.timingCurve,
                    keysCurve,
                };
            }
            catch (Exception)
            {
                return new List<AnimationCurve>();
            }
            
        }
    }

}
