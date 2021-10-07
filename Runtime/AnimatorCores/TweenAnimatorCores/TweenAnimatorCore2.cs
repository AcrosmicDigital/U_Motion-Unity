using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace U.Motion
{
    public abstract class TweenAnimatorCore<TValueX, TValueY> : TimeAnimatorCore
    {
       
        public KeyFramesCurve<TValueX> keysCurveX; // Values that the animation will take in the curve
        public KeyFramesCurve<TValueY> keysCurveY; // Values that the animation will take in the curve

        public Action<TValueX, TValueY> animate;


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
                    timeCurve,
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

