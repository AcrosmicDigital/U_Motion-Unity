using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace U.Motion
{

    // Probada

    public class BoolKeyframesCurve : KeyFramesCurve<bool>
    {
        public BoolKeyframesCurve(Dictionary<int, bool> keys, Uanimation.KeysCurveMode curveMode) : base(keys, curveMode) { }

        protected override float GetFloatFromTValue(bool value)
        {
            if (value)
                return 1;
            else
                return 0;
        }

        protected override bool GetTValueFromFloat(float value)
        {
            if (value > .5f)
                return true;
            else 
                return false;
        }
    }

}
