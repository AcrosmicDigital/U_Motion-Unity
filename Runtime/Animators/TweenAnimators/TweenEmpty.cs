using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

namespace U.Motion
{

    public partial class Uanimators
    {
        public class TweenEmpty : TimeAnimatorCore
        {
            public override List<AnimationCurve> GetCurves()
            {
                return new List<AnimationCurve>();
            }

            protected override void OnUpdate(float copletedPercentage)
            {
                // Just do delay
            }




            #region Factory

            [Serializable]
            public class Properties
            {
                public string animationName = "";
                public bool playOnAwake = true;
                public float duration = 2;
                public Utween.TimeMode timeMode = Utween.TimeMode.DeltaTime;
                public Utween.OnCompleteMode onCompleteMode = Utween.OnCompleteMode.Destroy;
                public bool allowUnexpectedEnd = true; // If true no error will be throw if animation is deleted

                [Space(8)]
                public UnityEvent onComplete = new UnityEvent();

            }


            public static TweenEmpty AddComponent(GameObject gameObject, Properties p)
            {
                if (p == null)
                    throw new ArgumentNullException("Tween properties cant be null");

                if (gameObject == null)
                    throw new ArgumentNullException("GameObject cant be null");

                if (p.duration <= 0)
                    throw new ArgumentException("Duration must be grater thar 0");


                var c = gameObject.AddComponent<TweenEmpty>();

                c.animationName = p.animationName;
                c.playOnAwake = p.playOnAwake;
                c.delay = 0;
                c.duration = p.duration;
                c.iterations = 1;
                c.direction = Utween.Direction.Normal;
                c.fillMode = Utween.FillMode.None;
                c.timeCurve = TimeCurve.linear;
                c.timeMode = p.timeMode;
                c.onCompleteMode = p.onCompleteMode;
                c.allowUnexpectedEnd = p.allowUnexpectedEnd;

                c.onComplete = p.onComplete;

                return c;
            }

            #endregion


        }


#if UNITY_EDITOR

        [CustomEditor(typeof(TweenEmpty))]
        public class TweenDelayInspectorExtension : TimeAnimatorCoreInspectorExtension { }


#endif

    }
}
