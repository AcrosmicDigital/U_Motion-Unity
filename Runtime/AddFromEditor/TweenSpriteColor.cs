using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using U.Motion;
using System.Linq;
using static U.Motion.UAnimation;

namespace U.Motion
{
    public class TweenSpriteColor : MonoBehaviour
    {
        [Space(10)]
        public SpriteRenderer c;

        public bool red = false;
        public bool green = false;
        public bool blue = false;
        public bool alpha = false;
        public TweenFloat.Properties tweenA;
        public TweenVector2.Properties tweenAB;
        public TweenVector3.Properties tweenABC;
        public TweenVector4.Properties tweenABCD;


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


            if ( (red && !green && !blue && !alpha) || (!red && green && !blue && !alpha) || (!red && !green && blue && !alpha) || (!red && !green && !blue && alpha))
            {
                if (tweenA.playOnAwake) AddTween();
            }


            else if ( (red && green && !blue && !alpha) || (red && !green && blue && !alpha) || (red && !green && !blue && alpha) || (!red && green && blue && !alpha) || (!red && green && !blue && alpha) || (!red && !green && blue && alpha))
            {
                if (tweenAB.playOnAwake) AddTween();
            }



            else if ( (!red && green && blue && alpha) || (red && !green && blue && alpha) || (red && green && !blue && alpha) || (red && green && blue && !alpha) )
            {
                if (tweenABC.playOnAwake) AddTween();
            }



            else if (red && green && blue && alpha)
            {
                if (tweenABCD.playOnAwake) AddTween();
            }

        }


        private void AddTween()
        {
            if (c == null) c = GetComponent<SpriteRenderer>();

            if (c == null) return;



            if (red && !green && !blue && !alpha)
            {
                animator = c.TweenColorR(tweenA);
            }
            else if (!red && green && !blue && !alpha)
            {
                animator = c.TweenColorG(tweenA);
            }
            else if (!red && !green && blue && !alpha)
            {
                animator = c.TweenColorB(tweenA);
            }
            else if (!red && !green && !blue && alpha)
            {
                animator = c.TweenColorA(tweenA);
            }


            else if (red && green && !blue && !alpha)
            {
                animator = c.TweenColorRG(tweenAB);
            }
            else if (red && !green && blue && !alpha)
            {
                animator = c.TweenColorRB(tweenAB);
            }
            else if (red && !green && !blue && alpha)
            {
                animator = c.TweenColorRA(tweenAB);
            }
            else if (!red && green && blue && !alpha)
            {
                animator = c.TweenColorGB(tweenAB);
            }
            else if (!red && green && !blue && alpha)
            {
                animator = c.TweenColorGA(tweenAB);
            }
            else if (!red && !green && blue && alpha)
            {
                animator = c.TweenColorBA(tweenAB);
            }



            else if (!red && green && blue && alpha)
            {
                animator = c.TweenColorGBA(tweenABC);
            }
            else if (red && !green && blue && alpha)
            {
                animator = c.TweenColorRBA(tweenABC);
            }
            else if (red && green && !blue && alpha)
            {
                animator = c.TweenColorRGA(tweenABC);
            }
            else if (red && green && blue && !alpha)
            {
                animator = c.TweenColorRGB(tweenABC);
            }



            else if (red && green && blue && alpha)
            {
                animator = c.TweenColorRGBA(tweenABCD);
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
