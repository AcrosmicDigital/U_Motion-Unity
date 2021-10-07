using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using U.Motion;
using System.Linq;
using static U.Motion.TweenAnimator;

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
        public TweenFloat.Properties colorTweenA;
        public TweenVector2.Properties colorTweenAB;
        public TweenVector3.Properties colorTweenABC;
        public TweenVector4.Properties colorTweenABCD;


        // Privs
        TimeAnimatorCore colorAnimator;

        private void Start()
        {
            if (c == null) c = GetComponent<SpriteRenderer>();

            if (c == null) return;



            if (red && !green && !blue && !alpha)
            {
                colorAnimator = c.TweenColorR(colorTweenA);
            }
            else if (!red && green && !blue && !alpha)
            {
                colorAnimator = c.TweenColorG(colorTweenA);
            }
            else if (!red && !green && blue && !alpha)
            {
                colorAnimator = c.TweenColorB(colorTweenA);
            }
            else if (!red && !green && !blue && alpha)
            {
                colorAnimator = c.TweenColorA(colorTweenA);
            }


            else if (red && green && !blue && !alpha)
            {
                colorAnimator = c.TweenColorRG(colorTweenAB);
            }
            else if (red && !green && blue && !alpha)
            {
                colorAnimator = c.TweenColorRB(colorTweenAB);
            }
            else if (red && !green && !blue && alpha)
            {
                colorAnimator = c.TweenColorRA(colorTweenAB);
            }
            else if (!red && green && blue && !alpha)
            {
                colorAnimator = c.TweenColorGB(colorTweenAB);
            }
            else if (!red && green && !blue && alpha)
            {
                colorAnimator = c.TweenColorGA(colorTweenAB);
            }
            else if (!red && !green && blue && alpha)
            {
                colorAnimator = c.TweenColorBA(colorTweenAB);
            }



            else if (!red && green && blue && alpha)
            {
                colorAnimator = c.TweenColorGBA(colorTweenABC);
            }
            else if (red && !green && blue && alpha)
            {
                colorAnimator = c.TweenColorRBA(colorTweenABC);
            }
            else if (red && green && !blue && alpha)
            {
                colorAnimator = c.TweenColorRGA(colorTweenABC);
            }
            else if (red && green && blue && !alpha)
            {
                colorAnimator = c.TweenColorRGB(colorTweenABC);
            }



            else if (red && green && blue && alpha)
            {
                colorAnimator = c.TweenColorRGBA(colorTweenABCD);
            }
        }



        public void Play()
        {
            colorAnimator?.Play();
        }

        public void Pause()
        {
            colorAnimator?.Pause();
        }

        public void Restart()
        {
            colorAnimator?.Restart();
        }

        public void CompleteNow()
        {
            colorAnimator?.CompleteNow();
        }
    }
}
