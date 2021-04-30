using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace U.Motion
{
    public abstract class TweenAnimator<TValueX, TValueY, TValueZ> : TimeAnimatorCore
    {
        
        public KeyFramesCurve<TValueX> keysCurveX; // Values that the animation will take in the curve
        public KeyFramesCurve<TValueY> keysCurveY; // Values that the animation will take in the curve
        public KeyFramesCurve<TValueZ> keysCurveZ; // Values that the animation will take in the curve

        public Action<TValueX, TValueY, TValueZ> animate;


        public void Set(
            Action<TValueX, TValueY, TValueZ> animate,
            KeyFramesCurve<TValueX> keysCurveX,
            KeyFramesCurve<TValueY> keysCurveY,
            KeyFramesCurve<TValueZ> keysCurveZ,
            TimeAnimationParams animationParams = null
            )
        {
            
            this.animate = animate;
            this.keysCurveX = keysCurveX;
            this.keysCurveY = keysCurveY;
            this.keysCurveZ = keysCurveZ;

            base.Set(animationParams);

        }


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
                    config.timingCurve,
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
