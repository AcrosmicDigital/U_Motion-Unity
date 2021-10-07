using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace U.Motion
{
    public static partial class Utween
    {

        public static ImpulseFloat ImpulseFloat(
            GameObject gameObject,
            float preferedValue,
            Action<float> impulse,
            ImpulseAnimatorParams animationParams = null
            )
        {

            var animator = gameObject.AddComponent<ImpulseFloat>();

            animator.Set(
                preferedValue,
                impulse,
                animationParams
                );

            return animator;

        }


        public static ImpulseInt ImpulseInt(
            GameObject gameObject,
            int preferedValue,
            Action<int> impulse,
            ImpulseAnimatorParams animationParams = null
            )
        {

            var animator = gameObject.AddComponent<ImpulseInt>();

            animator.Set(
                preferedValue,
                impulse,
                animationParams
                );

            return animator;

        }


    }




}