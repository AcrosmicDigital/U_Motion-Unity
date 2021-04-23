using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace U.Motion
{
    public class ImpulseFloat : ImpulseAnimatorCore
    {

        protected override void OnUpdate(float currentValue)
        {
            animate?.Invoke(currentValue);
        }


        public void Impulse(float targetValue, float duration, float delay = 0, float timeToReachImpulse = 0, float timeToDeleteImpulse = 0)
        {
            base.DoImpulse(targetValue, duration, delay, timeToReachImpulse, timeToDeleteImpulse);
        }


        public Action<float> animate;


        public void Set(
            float preferedValue,
            Action<float> animate,
            ImpulseAnimatorParams animationParams = null
            )
        {

            this.animate = animate;

            base.Set(preferedValue, animationParams);
        }

    }
}
