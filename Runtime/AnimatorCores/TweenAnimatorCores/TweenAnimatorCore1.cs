using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

namespace U.Motion
{
    public abstract class TweenAnimatorCore<TValue> : TimeAnimatorCore
    {
        // Properties

        public KeyFramesCurve<TValue> keysCurveX; // Values that the animation will take in the curve

        public Action<TValue> animate;

        // /Properties



        protected override void OnUpdate(float copletedPercentage)
        {
            animate?.Invoke(keysCurveX.Evaluate(copletedPercentage));
        }


        public override List<AnimationCurve> GetCurves()
        {
            try
            {
                return new List<AnimationCurve>
                {
                    timeCurve,
                    keysCurveX,
                };
            }
            catch (Exception)
            {
                return new List<AnimationCurve>();
            }
            
        }
    }

}
