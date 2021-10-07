using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace U.Motion
{
    public partial class TweenAnimator
    {
        public class TweenVector3 : TweenAnimatorCore<float, float, float>
        {

            #region Factory

            [Serializable]
            public class Properties
            {
                public string animationName = "";
                public bool playOnAwake = true;
                public float delay = 0;
                public float duration = 2;
                public int iterations = 1;
                public Utween.Direction direction = Utween.Direction.Normal;
                public Utween.FillMode fillMode = Utween.FillMode.Both;
                public TimeCurve.TimeCurveMode timeCurveMode = TimeCurve.TimeCurveMode.easeInOut;
                public Utween.TimeMode timeMode = Utween.TimeMode.UnscaledDeltaTime;
                public Utween.OnCompleteMode onCompleteMode = Utween.OnCompleteMode.Disable;
                public Utween.KeysCurveMode keysCurveMode = Utween.KeysCurveMode.Slope;
                public bool allowUnexpectedEnd = true; // If true no error will be throw if animation is deleted

                [Space(8)]

                public Keyframe[] keyframes;
                public Action<float, float, float> animate;  // Dont show in editor
            }


            [Serializable]
            public class Keyframe
            {
                public int key;
                public Vector3 value;
            }


            public static TweenVector3 AddComponent(GameObject gameObject, Properties p)
            {
                if (p == null)
                    throw new ArgumentNullException("Tween properties cant be null");

                if (gameObject == null)
                    throw new ArgumentNullException("GameObject cant be null");

                if (p.duration <= 0)
                    throw new ArgumentException("Duration must be grater thar 0");

                if (p.delay < 0)
                    throw new ArgumentException("Delay must be 0 or grater");

                if (p.iterations <= 0)
                    throw new ArgumentException("Iterations must be grater thar 0");


                // Create the Keys Curves
                var keysCurveX = new FloatKeyFramesCurve(p.keyframes.ToDictionary(k => k.key, v => v.value.x), p.keysCurveMode);
                var keysCurveY = new FloatKeyFramesCurve(p.keyframes.ToDictionary(k => k.key, v => v.value.y), p.keysCurveMode);
                var keysCurveZ = new FloatKeyFramesCurve(p.keyframes.ToDictionary(k => k.key, v => v.value.z), p.keysCurveMode);



                var c = gameObject.AddComponent<TweenVector3>();

                c.animationName = p.animationName;
                c.playOnAwake = p.playOnAwake;
                c.delay = p.delay;
                c.duration = p.duration;
                c.iterations = p.iterations;
                c.direction = p.direction;
                c.fillMode = p.fillMode;
                c.timeCurve = TimeCurve.SelectTimeCurve(p.timeCurveMode);
                c.timeMode = p.timeMode;
                c.onCompleteMode = p.onCompleteMode;
                c.allowUnexpectedEnd = p.allowUnexpectedEnd;

                c.keysCurveX = keysCurveX;
                c.keysCurveY = keysCurveY;
                c.keysCurveZ = keysCurveZ;
                c.animate = p.animate;

                return c;
            }

            #endregion

        }

#if UNITY_EDITOR

        [CustomEditor(typeof(TweenVector3))]
        public class TweenVector3InspectorExtension : TimeAnimatorCoreInspectorExtension { }

#endif
    }
}