using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using U.Motion;
using System.Linq;
using static U.Motion.UAnimation;

namespace U.Motion
{
    public class TweenTransformLocalPosition : MonoBehaviour
    {
        [Space(10)]
        public Transform t;

        [Header("Position")]
        public bool x = false;
        public bool y = false;
        public bool z = false;
        public TweenFloat.Properties tweenA;
        public TweenVector2.Properties tweenAB;
        public TweenVector3.Properties tweenABC;

        // Privs
        IAnimatorCore animator;
        IAnimatorCore _animator
        {
            get
            {
                if (animator == null) AddTween();
                else if (animator.isDestroyed) AddTween();

                return animator;
            }
        }

        private void Start()
        {


            if ((x && !y && !z) || (!x && y && !z) || (!x && !y && z) )
            {
                if (tweenA.playOnAwake) AddTween();
            }


            else if ((x && y && !z) || (x && !y && z) || (!x && y && z))
            {
                if (tweenAB.playOnAwake) AddTween();
            }


            else if (x && y && z)
            {
                if (tweenABC.playOnAwake) AddTween();
            }

        }


        private void AddTween()
        {

            if (t == null) t = transform;

            if (t == null) return;





            if (x && !y && !z)
            {
                animator = t.TweenLocalPositionX(tweenA);
            }
            else if (!x && y && !z)
            {
                animator = t.TweenLocalPositionY(tweenA);
            }
            else if (!x && !y && z)
            {
                animator = t.TweenLocalPositionZ(tweenA);
            }

            else if (x && y && !z)
            {
                animator = t.TweenLocalPositionXY(tweenAB);
            }
            else if (x && !y && z)
            {
                animator = t.TweenLocalPositionXZ(tweenAB);
            }
            else if (!x && y && z)
            {
                animator = t.TweenLocalPositionYZ(tweenAB);
            }

            else if (x && y && z)
            {
                animator = t.TweenLocalPositionXYZ(tweenABC);
            }

        }



        public void Play()
        {
            _animator.Play();
        }

        public void Pause()
        {
            _animator.Pause();
        }

        public void Restart()
        {
            _animator.Restart();
        }

        public void CompleteNow()
        {
            _animator.CompleteNow();
        }

    }
}
