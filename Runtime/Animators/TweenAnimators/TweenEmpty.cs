using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

namespace U.Motion
{

    public partial class UAnimation
    {
        public class TweenEmpty : TweenAnimatorCore
        {

            #region Factory

            [Serializable]
            public class Properties
            {
                public string animationName = "";
                public bool playOnAwake = true;
                public float duration = 2;
                public UAnimation.TimeMode timeMode = UAnimation.TimeMode.DeltaTime;
                public UAnimation.OnCompleteMode onCompleteMode = UAnimation.OnCompleteMode.Destroy;
                public bool allowUnexpectedEnd = true; // If true no error will be throw if animation is deleted

                [Space(8)]
                public Action onCompleteAction = () => { };
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
                c.direction = Direction.Normal;
                c.fillMode = FillMode.None;
                c.timeCurve = TimeCurve.linear;
                c.timeMode = p.timeMode;
                c.onCompleteMode = p.onCompleteMode;
                c.allowUnexpectedEnd = p.allowUnexpectedEnd;

                c.onComplete = p.onComplete;
                c.onComplete.AddListener(() =>
                {
                    p.onCompleteAction?.Invoke();
                });

                return c;
            }

            #endregion


        }

    }
}
