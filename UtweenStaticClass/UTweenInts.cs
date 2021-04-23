using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace U.Motion
{
    public static partial class Utween
    {

        public static TweenInt AnimateInt(
            GameObject gameObject,
            Action<int> animate,
            Dictionary<int, int> keyFrames,
            TimeAnimationParams animationParams = null,
            KeysCurveMode keysCurveMode = KeysCurveMode.Slope
            )
        {

            var animator = gameObject.AddComponent<TweenInt>();

            animator.Set(
                animate,
                new IntKeysCurve(keyFrames, keysCurveMode),
                animationParams
                );

            return animator;

        }


    }




}


