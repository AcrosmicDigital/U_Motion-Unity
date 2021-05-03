using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace U.Motion
{
    public static partial class Utween
    {

        public static TweenAnimator.TweenInt AnimateInt(
            GameObject gameObject,
            Action<int> animate,
            Dictionary<int, int> keyFrames,
            TimeAnimationParams animationParams = null,
            KeysCurveMode keysCurveMode = KeysCurveMode.Slope
            )
        {

            var animator = gameObject.AddComponent<TweenAnimator.TweenInt>();

            animator.Set(
                animate,
                new IntKeyFramesCurve(keyFrames, keysCurveMode),
                animationParams
                );

            return animator;

        }


    }




}


