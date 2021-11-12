using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

namespace U.Motion
{
    public abstract class TweenAnimatorCore : TimeAnimatorCore
    {

        protected override void OnUpdate(float copletedPercentage)
        {
            // Just do delay
        }


        public override List<AnimationCurve> GetCurves()
        {
            try
            {
                return new List<AnimationCurve>
                {
                    timeCurve,
                };
            }
            catch (Exception)
            {
                return new List<AnimationCurve>();
            }

        }
    }

}
