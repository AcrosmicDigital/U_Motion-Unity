using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace U.Motion
{
    public abstract class TweenAnimator<TValueX, TValueY, TValueZ, TValueW, TValueH, TValueI, TValueJ> : TimeAnimatorCore
    {

        public KeysCurve<TValueX> keysCurveX; // Values that the animation will take in the curve
        public KeysCurve<TValueY> keysCurveY; // Values that the animation will take in the curve
        public KeysCurve<TValueZ> keysCurveZ; // Values that the animation will take in the curve
        public KeysCurve<TValueW> keysCurveW; // Values that the animation will take in the curve
        public KeysCurve<TValueH> keysCurveH; // Values that the animation will take in the curve
        public KeysCurve<TValueI> keysCurveI; // Values that the animation will take in the curve
        public KeysCurve<TValueJ> keysCurveJ; // Values that the animation will take in the curve


        public Action<TValueX, TValueY, TValueZ, TValueW, TValueH, TValueI, TValueJ> animate;


        public void Set(
            Action<TValueX, TValueY, TValueZ, TValueW, TValueH, TValueI, TValueJ> animate,
            KeysCurve<TValueX> keysCurveX,
            KeysCurve<TValueY> keysCurveY,
            KeysCurve<TValueZ> keysCurveZ,
            KeysCurve<TValueW> keysCurveW,
            KeysCurve<TValueH> keysCurveH,
            KeysCurve<TValueI> keysCurveI,
            KeysCurve<TValueJ> keysCurveJ,
            TimeAnimationParams animationParams = null
            )
        {
            
            this.animate = animate;
            this.keysCurveX = keysCurveX;
            this.keysCurveY = keysCurveY;
            this.keysCurveZ = keysCurveZ;
            this.keysCurveW = keysCurveW;
            this.keysCurveH = keysCurveH;
            this.keysCurveI = keysCurveI;
            this.keysCurveJ = keysCurveJ;

            base.Set(animationParams);

        }

        protected override void OnUpdate(float copletedPercentage)
        {
            animate?.Invoke(
                keysCurveX.Evaluate(copletedPercentage),
                keysCurveY.Evaluate(copletedPercentage),
                keysCurveZ.Evaluate(copletedPercentage),
                keysCurveW.Evaluate(copletedPercentage),
                keysCurveH.Evaluate(copletedPercentage),
                keysCurveI.Evaluate(copletedPercentage),
                keysCurveJ.Evaluate(copletedPercentage)
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
                    keysCurveW,
                    keysCurveH,
                    keysCurveI,
                    keysCurveJ,
                };
            }
            catch (Exception)
            {
                return new List<AnimationCurve>();
            }
            
        }
    }
}

