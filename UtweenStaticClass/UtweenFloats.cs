using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace U.Motion
{
    public static partial class Utween
    {

        public static TweenFloat AnimateFloat(
            GameObject gameObject,
            Action<float> animate,
            Dictionary<int, float> keyFrames,
            TimeAnimationParams animationParams = null,
            KeysCurveMode keysCurveMode = KeysCurveMode.Slope
            )
        {

            var animator = gameObject.AddComponent<TweenFloat>();

            animator.Set(
                animate,
                new FloatKeysCurve(keyFrames, keysCurveMode),
                animationParams
                );

            return animator;

        }



        public static TweenVector2 AnimateVector2(
            GameObject gameObject,
            Action<float, float> animate,
            Dictionary<int, Vector2> keyFrames,
            TimeAnimationParams animationParams = null,
            KeysCurveMode keysCurveMode = KeysCurveMode.Slope
            )
        {

            var animator = gameObject.AddComponent<TweenVector2>();

            animator.Set(
                animate,
                new FloatKeysCurve(keyFrames.ToDictionary(k => k.Key, v => v.Value.x), keysCurveMode),
                new FloatKeysCurve(keyFrames.ToDictionary(k => k.Key, v => v.Value.y), keysCurveMode),
                animationParams
                );

            return animator;

        }



        public static TweenVector3 AnimateVector3(
            GameObject gameObject,
            Action<float, float, float> animate,
            Dictionary<int, Vector3> keyFrames,
            TimeAnimationParams animationParams = null,
            KeysCurveMode keysCurveMode = KeysCurveMode.Slope
            )
        {

            var animator = gameObject.AddComponent<TweenVector3>();

            animator.Set(
                animate,
                new FloatKeysCurve(keyFrames.ToDictionary(k => k.Key, v => v.Value.x), keysCurveMode),
                new FloatKeysCurve(keyFrames.ToDictionary(k => k.Key, v => v.Value.y), keysCurveMode),
                new FloatKeysCurve(keyFrames.ToDictionary(k => k.Key, v => v.Value.z), keysCurveMode),
                animationParams
                );

            return animator;

        }




        public static TweenVector4 AnimateVector4(
            GameObject gameObject,
            Action<float, float, float, float> animate,
            Dictionary<int, Vector4> keyFrames,
            TimeAnimationParams animationParams = null,
            KeysCurveMode keysCurveMode = KeysCurveMode.Slope
            )
        {

            var animator = gameObject.AddComponent<TweenVector4>();

            animator.Set(
                animate,
                new FloatKeysCurve(keyFrames.ToDictionary(k => k.Key, v => v.Value.x), keysCurveMode),
                new FloatKeysCurve(keyFrames.ToDictionary(k => k.Key, v => v.Value.y), keysCurveMode),
                new FloatKeysCurve(keyFrames.ToDictionary(k => k.Key, v => v.Value.z), keysCurveMode),
                new FloatKeysCurve(keyFrames.ToDictionary(k => k.Key, v => v.Value.w), keysCurveMode),
                animationParams
                );

            return animator;

        }






    }


}

