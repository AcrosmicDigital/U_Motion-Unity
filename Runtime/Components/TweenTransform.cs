using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using U.Motion;
using System.Linq;
using static U.Motion.TweenAnimator;

namespace U.Motion
{
    public class TweenTransform : Tween
    {
        [Space(10)]
        public Transform t;

        [Header("Position")]
        public bool tweenPosition = false;
        public bool positionX = false;
        public bool positionY = false;
        public bool positionZ = false;
        public TweenFloat.Properties positionTweenA;
        public TweenVector2.Properties positionTweenAB;
        public TweenVector3.Properties positionTweenABC;

        [Header("Rotation")]
        public bool tweenRotation = false;
        public bool rotationX = false;
        public bool rotationY = false;
        public bool rotationZ = false;
        public TweenFloat.Properties rotationTweenA;
        public TweenVector2.Properties rotationTweenAB;
        public TweenVector3.Properties rotationTweenABC;

        [Header("Scale")]
        public bool tweenScale = false;
        public bool scaleX = false;
        public bool scaleY = false;
        public bool scaleZ = false;
        public TweenFloat.Properties scaleTweenA;
        public TweenVector2.Properties scaleTweenAB;
        public TweenVector3.Properties scaleTweenABC;

        // Privs
        IanimatorCore positionAnimator;
        IanimatorCore rotationAnimator;
        IanimatorCore scaleAnimator;

        private void Start()
        {

            if (t == null) t = transform;

            if (t == null) return;



            if (tweenPosition)
            {
                if (positionX && !positionY && !positionZ)
                {
                    positionAnimator = t.TweenPositionX(positionTweenA);
                }
                else if (!positionX && positionY && !positionZ)
                {
                    positionAnimator = t.TweenPositionY(positionTweenA);
                }
                else if (!positionX && !positionY && positionZ)
                {
                    positionAnimator = t.TweenPositionZ(positionTweenA);
                }

                else if (positionX && positionY && !positionZ)
                {
                    positionAnimator = t.TweenPositionXY(positionTweenAB);
                }
                else if (positionX && !positionY && positionZ)
                {
                    positionAnimator = t.TweenPositionXZ(positionTweenAB);
                }
                else if (!positionX && positionY && positionZ)
                {
                    positionAnimator = t.TweenPositionYZ(positionTweenAB);
                }

                else if (positionX && positionY && positionZ)
                {
                    positionAnimator = t.TweenPositionXYZ(positionTweenABC);
                }
            }

            if (tweenRotation)
            {
                if (rotationX && !rotationY && !rotationZ)
                {
                    rotationAnimator = t.TweenRotationX(rotationTweenA);
                }
                else if (!rotationX && rotationY && !rotationZ)
                {
                    rotationAnimator = t.TweenRotationY(rotationTweenA);
                }
                else if (!rotationX && !rotationY && rotationZ)
                {
                    rotationAnimator = t.TweenRotationZ(rotationTweenA);
                }

                else if (rotationX && rotationY && !rotationZ)
                {
                    rotationAnimator = t.TweenRotationXY(rotationTweenAB);
                }
                else if (rotationX && !rotationY && rotationZ)
                {
                    rotationAnimator = t.TweenRotationXZ(rotationTweenAB);
                }
                else if (!rotationX && rotationY && rotationZ)
                {
                    rotationAnimator = t.TweenRotationYZ(rotationTweenAB);
                }

                else if (rotationX && rotationY && rotationZ)
                {
                    rotationAnimator = t.TweenRotationXYZ(rotationTweenABC);
                }
            }

            if (tweenScale)
            {
                if (scaleX && !scaleY && !scaleZ)
                {
                    scaleAnimator = t.TweenScaleX(scaleTweenA);
                }
                else if (!scaleX && scaleY && !scaleZ)
                {
                    scaleAnimator = t.TweenScaleY(scaleTweenA);
                }
                else if (!scaleX && !scaleY && scaleZ)
                {
                    scaleAnimator = t.TweenScaleZ(scaleTweenA);
                }

                else if (scaleX && scaleY && !scaleZ)
                {
                    scaleAnimator = t.TweenScaleXY(scaleTweenAB);
                }
                else if (scaleX && !scaleY && scaleZ)
                {
                    scaleAnimator = t.TweenScaleXZ(scaleTweenAB);
                }
                else if (!scaleX && scaleY && scaleZ)
                {
                    scaleAnimator = t.TweenScaleYZ(scaleTweenAB);
                }

                else if (scaleX && scaleY && scaleZ)
                {
                    scaleAnimator = t.TweenScaleXYZ(scaleTweenABC);
                }
            }




        }


        public void PlayPosition()
        {
            positionAnimator?.Play();
        }

        public void PlayRotation()
        {
            rotationAnimator?.Play();
        }

        public void PlayScale()
        {
            scaleAnimator?.Play();
        }

        public override void Play()
        {
            positionAnimator?.Play();
            rotationAnimator?.Play();
            scaleAnimator?.Play();
        }



        public void PausePosition()
        {
            positionAnimator?.Pause();
        }

        public void PauseRotation()
        {
            rotationAnimator?.Pause();
        }

        public void PauseScale()
        {
            scaleAnimator?.Pause();
        }

        public void PauseAll()
        {
            positionAnimator?.Pause();
            rotationAnimator?.Pause();
            scaleAnimator?.Pause();
        }





        public void RestartPosition()
        {
            positionAnimator?.Restart();
        }

        public void RestartRotation()
        {
            rotationAnimator?.Restart();
        }

        public void RestartScale()
        {
            scaleAnimator?.Restart();
        }

        public void RestartAll()
        {
            positionAnimator?.Restart();
            rotationAnimator?.Restart();
            scaleAnimator?.Restart();
        }






        public void CompleteNowPosition()
        {
            positionAnimator?.CompleteNow();
        }

        public void CompleteNowRotation()
        {
            rotationAnimator?.CompleteNow();
        }

        public void CompleteNowScale()
        {
            scaleAnimator?.CompleteNow();
        }

        public void CompleteNowAll()
        {
            positionAnimator?.CompleteNow();
            rotationAnimator?.CompleteNow();
            scaleAnimator?.CompleteNow();
        }

    }
}