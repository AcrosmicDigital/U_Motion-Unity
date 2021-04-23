using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace U.Motion
{
    public static partial class Utween
    {
        public enum Direction
        {
            Normal,  // Animation is as normal
            Reverse,  // Animation is in reverse
            Alternate,  // Animation is one in normal and one in reverse
            AlternateReverse,  // Animation is one in normal, and one in reverse
        }

        public enum FillMode
        {
            None,  // Values are not applied
            Forwards,  // Last frame value will be applied on animation finish or CompleteNow
            Backwards,  // Initial keyframe value will be applied on finish or CompleteNow
            Both,  // Se quedara el valor que tiene al momento de darle CompleteNow
        }

        public enum OnCompleteMode
        {
            None,  // Not disable the component
            Disable,  // Disable the tween component
            Loop,  // Loop the animation
            Destroy,  // Destroy the ctween component
        }

        public enum KeysCurveMode
        {
            Slope,   // Is a triangle curve , when pass from value one two value two, all intermediate values are posible
            Step,  // Is a step curve, use for animate values and dont pass throught intermediate values, just jum from one to other
        }

        public enum TimeMode
        {
            DeltaTime,
            UnscaledDeltaTime,
        }

    }

}

