using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U.Motion
{

    // Provada
    
    
    public class EaseCurve
    {

        private readonly AnimationCurve animationCurve;

        public EaseCurve(Keyframe[] keys)
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

        public static implicit operator AnimationCurve(EaseCurve timingFunction)
        {
            return timingFunction.animationCurve;
        }







        public static EaseCurve linear => new EaseCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 1),
            new Keyframe(1f, 1f, 1, 0),
        });


        
        public static EaseCurve easeIn => new EaseCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0),
            new Keyframe(1f, 1f, 1, 0),
        });

        public static EaseCurve easeOut => new EaseCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 1),
            new Keyframe(1f, 1f, 0, 0),
        });
        public static EaseCurve easeInOut => new EaseCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0),
            new Keyframe(1f, 1f, 0, 0),
        });



        public static EaseCurve circIn => new EaseCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0),
            new Keyframe(.5f, .1f, .46f, .46f),
            new Keyframe(1f, 1f, 4f, 0),
        });

        public static EaseCurve circOut => new EaseCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 4f),
            new Keyframe(.5f, .9f, .46f, .46f),
            new Keyframe(1f, 1f, 0f, 0),
        });
        public static EaseCurve circInOut => new EaseCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0),
            new Keyframe(.3f, .06f, .46f, .46f),
            new Keyframe(.5f, .5f, 4f, 4f),
            new Keyframe(.7f, .94f, .46f, .46f),
            new Keyframe(1f, 1f, 0, 0),
        });



        public static EaseCurve bounceIn => new EaseCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0),
            new Keyframe(.05f, 0f, 0, 0),
            new Keyframe(.12f, 0f, 0, 0),
            new Keyframe(.2f, 0f, 0, 0),
            new Keyframe(1f, 1f, 5.73f, 0),
        });

        public static EaseCurve bounceOut => new EaseCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 5.73f),
            new Keyframe(.5f, 1f, 0, 0),
            new Keyframe(1f, 1f, 0f, 0),
        });
        public static EaseCurve bounceInOut => new EaseCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0),
            new Keyframe(.3f, 0f, 0, 0),
            new Keyframe(.5f, .5f, 5.73f, 5.73f),
            new Keyframe(.7f, 1f, 0, 0),
            new Keyframe(1f, 1f, 0, 0),
        });



        public static EaseCurve elasticIn => new EaseCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0),
            new Keyframe(.5f, 0f, 0, 0),
            new Keyframe(1f, 1f, 5.73f, 0),
        });

        public static EaseCurve elasticOut => new EaseCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 5.73f),
            new Keyframe(.5f, 1f, 0, 0),
            new Keyframe(1f, 1f, 0f, 0),
        });
        public static EaseCurve elasticInOut => new EaseCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0),
            new Keyframe(.3f, 0f, 0, 0),
            new Keyframe(.5f, .5f, 5.73f, 5.73f),
            new Keyframe(.7f, 1f, 0, 0),
            new Keyframe(1f, 1f, 0, 0),
        });




























        public static EaseCurve fast => new EaseCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 5.73f),
            new Keyframe(.3f, .5f, 0, 0),
            new Keyframe(.5f, .5f, 0, 0),
            new Keyframe(.7f, .5f, 0, 0),
            new Keyframe(1f, 1f, 5.73f, 0),
        });

        public static EaseCurve bisine => new EaseCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0f),
            new Keyframe(.2f, 1f, 0, 0),
            new Keyframe(.4f, 0f, 0, 0),
            new Keyframe(.6f, 1f, 0, 0f),
            new Keyframe(.8f, 0f, 0, 0),
            new Keyframe(1f, 1f, 0, 0),
        });

        public static EaseCurve sine => new EaseCurve(new Keyframe[]
        {
            new Keyframe(0f, 0f, 0, 0),
            new Keyframe(.333f, 1f, 0, 0),
            new Keyframe(.666f, 0f, 0f, 0),
            new Keyframe(1f, 1f, 0f, 0),
        });
    }

}


