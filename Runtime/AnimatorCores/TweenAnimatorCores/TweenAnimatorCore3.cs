using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace U.Motion
{
    public abstract class TweenAnimatorCore<TValueX, TValueY, TValueZ> : TimeAnimatorCore
    {
        
        public KeyFramesCurve<TValueX> keysCurveX; // Values that the animation will take in the curve
        public KeyFramesCurve<TValueY> keysCurveY; // Values that the animation will take in the curve
        public KeyFramesCurve<TValueZ> keysCurveZ; // Values that the animation will take in the curve

        public Action<TValueX, TValueY, TValueZ> animate;





        protected override void OnUpdate(float copletedPercentage)
        {
            animate?.Invoke(
                keysCurveX.Evaluate(copletedPercentage), 
                keysCurveY.Evaluate(copletedPercentage), 
                keysCurveZ.Evaluate(copletedPercentage)
                );
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
                    keysCurveZ,
                };
            }
            catch (Exception)
            {
                return new List<AnimationCurve>();
            }

            
        }
    }
}
