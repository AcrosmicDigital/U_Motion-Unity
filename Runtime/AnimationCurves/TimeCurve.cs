using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U.Motion
{

    // Provada
    
    
    public class TimeCurve
    {

        public enum TimeCurveMode
        {
            Linear,

            easeIn,
            easeOut,
            easeInOut,

            circIn,
            circOut,
            circInOut,

            bounceIn,
            bounceOut,
            bounceInOut,

            elasticIn,
            elasticOut,
            elasticInOut,

            fast,
            bisine,
            sine,
        }

        private readonly AnimationCurve animationCurve;

        public TimeCurve(Keyframe[] keys)
        {
            // Check the keys

            for (var i = 0; i < keys.Length; i++)
            {
                if (keys[i].time < 0 || keys[i].time > 1)
                {
                    throw new ArgumentOutOfRangeException("Key.time must be >=0 and <=1");
                }

                if (keys[i].value < 0 || keys[i].value > 1)
                {
                    throw new ArgumentOutOfRangeException("Key.value must be >=0 and <=1");
                }

                keys[i].inWeight = 0;
                keys[i].weightedMode = WeightedMode.None;
                keys[i].outWeight = 0;

            }

            // Create the animation curve
            animationCurve = new AnimationCurve(keys);

        }


        public float Evaluate(float time) => animationCurve.Evaluate(time);

        public static implicit operator AnimationCurve(TimeCurve timingFunction)
        {
            return timingFunction.animationCurve;
        }


        public static TimeCurve SelectTimeCurve(TimeCurveMode mode)
        {
            switch (mode)
            {
                case TimeCurveMode.Linear:
                    return TimeCurve.linear;

                case TimeCurveMode.easeIn:
                    return TimeCurve.easeIn;
                case TimeCurveMode.easeOut:
                    return TimeCurve.easeOut;
                case TimeCurveMode.easeInOut:
                    return TimeCurve.easeInOut;

                case TimeCurveMode.circIn:
                    return TimeCurve.circIn;
                case TimeCurveMode.circOut:
                    return TimeCurve.circOut;
                case TimeCurveMode.circInOut:
                    return TimeCurve.circInOut;

                case TimeCurveMode.bounceIn:
                    return TimeCurve.bounceIn;
                case TimeCurveMode.bounceOut:
                    return TimeCurve.bounceOut;
                case TimeCurveMode.bounceInOut:
                    return TimeCurve.bounceInOut;

                case TimeCurveMode.elasticIn:
                    return TimeCurve.elasticIn;
                case TimeCurveMode.elasticOut:
                    return TimeCurve.elasticOut;
                case TimeCurveMode.elasticInOut:
                    return TimeCurve.elasticInOut;


                case TimeCurveMode.fast:
                    return TimeCurve.fast;
                case TimeCurveMode.sine:
                    return TimeCurve.sine;
                case TimeCurveMode.bisine:
                    return TimeCurve.bisine;

                default:
                    return TimeCurve.elasticInOut;

            }
        }



        // Linear
        public static TimeCurve linear => new TimeCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 1),
            new Keyframe(1f, 1f, 1, 0),
        });


        // Ease
        public static TimeCurve easeIn => new TimeCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0),
            new Keyframe(1f, 1f, 1, 0),
        });

        public static TimeCurve easeOut => new TimeCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 1),
            new Keyframe(1f, 1f, 0, 0),
        });
        public static TimeCurve easeInOut => new TimeCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0),
            new Keyframe(1f, 1f, 0, 0),
        });


        // Circle
        public static TimeCurve circIn => new TimeCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0),
            new Keyframe(.5f, .1f, .46f, .46f),
            new Keyframe(1f, 1f, 4f, 0),
        });

        public static TimeCurve circOut => new TimeCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 4f),
            new Keyframe(.5f, .9f, .46f, .46f),
            new Keyframe(1f, 1f, 0f, 0),
        });
        public static TimeCurve circInOut => new TimeCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0),
            new Keyframe(.3f, .06f, .46f, .46f),
            new Keyframe(.5f, .5f, 4f, 4f),
            new Keyframe(.7f, .94f, .46f, .46f),
            new Keyframe(1f, 1f, 0, 0),
        });


        // Bounce
        public static TimeCurve bounceIn => new TimeCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0),
            new Keyframe(.05f, 0f, 0, 0),
            new Keyframe(.12f, 0f, 0, 0),
            new Keyframe(.2f, 0f, 0, 0),
            new Keyframe(1f, 1f, 5.73f, 0),
        });

        public static TimeCurve bounceOut => new TimeCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 5.73f),
            new Keyframe(.5f, 1f, 0, 0),
            new Keyframe(1f, 1f, 0f, 0),
        });
        public static TimeCurve bounceInOut => new TimeCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0),
            new Keyframe(.3f, 0f, 0, 0),
            new Keyframe(.5f, .5f, 5.73f, 5.73f),
            new Keyframe(.7f, 1f, 0, 0),
            new Keyframe(1f, 1f, 0, 0),
        });


        // Elastic
        public static TimeCurve elasticIn => new TimeCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0),
            new Keyframe(.5f, 0f, 0, 0),
            new Keyframe(1f, 1f, 5.73f, 0),
        });

        public static TimeCurve elasticOut => new TimeCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 5.73f),
            new Keyframe(.5f, 1f, 0, 0),
            new Keyframe(1f, 1f, 0f, 0),
        });
        public static TimeCurve elasticInOut => new TimeCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0),
            new Keyframe(.3f, 0f, 0, 0),
            new Keyframe(.5f, .5f, 5.73f, 5.73f),
            new Keyframe(.7f, 1f, 0, 0),
            new Keyframe(1f, 1f, 0, 0),
        });









        // Otras
        public static TimeCurve fast => new TimeCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 5.73f),
            new Keyframe(.3f, .5f, 0, 0),
            new Keyframe(.5f, .5f, 0, 0),
            new Keyframe(.7f, .5f, 0, 0),
            new Keyframe(1f, 1f, 5.73f, 0),
        });

        public static TimeCurve bisine => new TimeCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0f),
            new Keyframe(.2f, 1f, 0, 0),
            new Keyframe(.4f, 0f, 0, 0),
            new Keyframe(.6f, 1f, 0, 0f),
            new Keyframe(.8f, 0f, 0, 0),
            new Keyframe(1f, 1f, 0, 0),
        });

        public static TimeCurve sine => new TimeCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0),
            new Keyframe(.333f, 1f, 0, 0),
            new Keyframe(.666f, 0f, 0f, 0),
            new Keyframe(1f, 1f, 0f, 0),
        });
    }

}


