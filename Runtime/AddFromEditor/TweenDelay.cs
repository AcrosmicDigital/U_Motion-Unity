using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using U.Motion;
using System.Linq;
using static U.Motion.Uanimators;

namespace U.Motion
{
    public class TweenDelay : MonoBehaviour
    {
        [Space(10)]
        public GameObject go;

        [Header("Position")]
        public TweenEmpty.Properties tween;

        // Privs
        IanimatorCore animator;
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
            if (tween.playOnAwake) AddTween();
        }


        private void AddTween()
        {

            if (go == null) go = gameObject;

            if (go == null) return;


            animator = go.TweenDelay(tween);

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
