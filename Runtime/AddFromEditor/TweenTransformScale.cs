using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using U.Motion;
using System.Linq;
using static U.Motion.Uanimators;

namespace U.Motion
{
    public class TweenTransformScale : MonoBehaviour
    {
        [Space(10)]
        public Transform t;

        [Header("Scale")]
        public bool x = false;
        public bool y = false;
        public bool z = false;
        public TweenFloat.Properties tweenA;
        public TweenVector2.Properties tweenAB;
        public TweenVector3.Properties tweenABC;

        // Privs
        private IanimatorCore animator;
        IanimatorCore _animator
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


            if ((x && !y && !z) || (!x && y && !z) || (!x && !y && z))
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
                animator = t.TweenScaleX(tweenA);
            }
            else if (!x && y && !z)
            {
                animator = t.TweenScaleY(tweenA);
            }
            else if (!x && !y && z)
            {
                animator = t.TweenScaleZ(tweenA);
            }

            else if (x && y && !z)
            {
                animator = t.TweenScaleXY(tweenAB);
            }
            else if (x && !y && z)
            {
                animator = t.TweenScaleXZ(tweenAB);
            }
            else if (!x && y && z)
            {
                animator = t.TweenScaleYZ(tweenAB);
            }

            else if (x && y && z)
            {
                animator = t.TweenScaleXYZ(tweenABC);
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
