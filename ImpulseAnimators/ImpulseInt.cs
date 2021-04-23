using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace U.Motion
{
    public class ImpulseInt : ImpulseAnimatorCore
    {
        protected override void OnUpdate(float currentValue)
        {
            impulse?.Invoke((int)currentValue);
        }


        
        public Action<int> impulse;


        public void Impulse(int targetValue, float duration, float delay = 0, float timeToReachImpulse = 0, float timeToDeleteImpulse = 0)
        {
            base.DoImpulse((int)targetValue, duration, delay, timeToReachImpulse, timeToDeleteImpulse);
        }



        public void Set(
            int preferedValue,
            Action<int> impulse,
            ImpulseAnimatorParams animationParams = null
            )
        {

            this.impulse = impulse;

            base.Set((int)preferedValue, animationParams);
        }

    }

}