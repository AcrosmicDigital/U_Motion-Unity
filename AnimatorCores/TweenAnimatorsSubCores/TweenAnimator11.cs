using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace U.Motion
{
    public abstract class TweenAnimator<TValueX, TValueY, TValueZ, TValueW, TValueH, TValueI, TValueJ, TValueK, TValueA, TValueB, TValueC> : TimeAnimatorCore
    {

        public KeyFramesCurve<TValueX> keysCurveX; // Values that the animation will take in the curve
        public KeyFramesCurve<TValueY> keysCurveY; // Values that the animation will take in the curve
        public KeyFramesCurve<TValueZ> keysCurveZ; // Values that the animation will take in the curve
        public KeyFramesCurve<TValueW> keysCurveW; // Values that the animation will take in the curve
        public KeyFramesCurve<TValueH> keysCurveH; // Values that the animation will take in the curve
        public KeyFramesCurve<TValueI> keysCurveI; // Values that the animation will take in the curve
        public KeyFramesCurve<TValueJ> keysCurveJ; // Values that the animation will take in the curve
        public KeyFramesCurve<TValueK> keysCurveK; // Values that the animation will take in the curve
        public KeyFramesCurve<TValueA> keysCurveA; // Values that the animation will take in the curve
        public KeyFramesCurve<TValueB> keysCurveB; // Values that the animation will take in the curve
        public KeyFramesCurve<TValueC> keysCurveC; // Values that the animation will take in the curve


        public Action<TValueX, TValueY, TValueZ, TValueW, TValueH, TValueI, TValueJ, TValueK, TValueA, TValueB, TValueC> animate;


        public void Set(
            Action<TValueX, TValueY, TValueZ, TValueW, TValueH, TValueI, TValueJ, TValueK, TValueA, TValueB, TValueC> animate,
            KeyFramesCurve<TValueX> keysCurveX,
            KeyFramesCurve<TValueY> keysCurveY,
            KeyFramesCurve<TValueZ> keysCurveZ,
            KeyFramesCurve<TValueW> keysCurveW,
            KeyFramesCurve<TValueH> keysCurveH,
            KeyFramesCurve<TValueI> keysCurveI,
            KeyFramesCurve<TValueJ> keysCurveJ,
            KeyFramesCurve<TValueK> keysCurveK,
            KeyFramesCurve<TValueA> keysCurveA,
            KeyFramesCurve<TValueB> keysCurveB,
            KeyFramesCurve<TValueC> keysCurveC,

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
            this.keysCurveK = keysCurveK;
            this.keysCurveA = keysCurveA;
            this.keysCurveB = keysCurveB;
            this.keysCurveC = keysCurveC;

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
                keysCurveJ.Evaluate(copletedPercentage),
                keysCurveK.Evaluate(copletedPercentage),
                keysCurveA.Evaluate(copletedPercentage),
                keysCurveB.Evaluate(copletedPercentage),
                keysCurveC.Evaluate(copletedPercentage)
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
                    keysCurveK,
                    keysCurveA,
                    keysCurveB,
                    keysCurveC,
                };
            }
            catch (Exception)
            {
                return new List<AnimationCurve>();
            }


        }
    }
}

