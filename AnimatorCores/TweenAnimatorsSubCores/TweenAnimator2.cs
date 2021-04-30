using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace U.Motion
{
    public abstract class TweenAnimator<TValueX, TValueY> : TimeAnimatorCore
    {
       
        public KeyFramesCurve<TValueX> keysCurveX; // Values that the animation will take in the curve
        public KeyFramesCurve<TValueY> keysCurveY; // Values that the animation will take in the curve

        public Action<TValueX, TValueY> animate;


        public void Set(
            Action<TValueX, TValueY> animate,
            KeyFramesCurve<TValueX> keysCurveX,
            KeyFramesCurve<TValueY> keysCurveY,
            TimeAnimationParams animationParams = null
            )
        {
            
            this.animate = animate;
            this.keysCurveX = keysCurveX;
            this.keysCurveY = keysCurveY;

            base.Set(animationParams);

        }

        protected override void OnUpdate(float copletedPercentage)
        {
            animate?.Invoke(keysCurveX.Evaluate(copletedPercentage), keysCurveY.Evaluate(copletedPercentage));
        }


        public override List<AnimationCurve> GetCurves()
        {
            try
            {
                return new List<AnimationCurve>
                {
                    config.timingCurve,
                    keysCurveX,
                    keysCurveY,
                };
            }
            catch (Exception)
            {
                return new List<AnimationCurve>();
            }

            
        }
    }
}

