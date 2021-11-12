using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace U.Motion
{

    // Probada

    public class FloatKeyFramesCurve : KeyFramesCurve<float>
    {
        public FloatKeyFramesCurve(Dictionary<int, float> keys, Uanimation.KeysCurveMode curveMode) : base(keys, curveMode) { }

        protected override float GetFloatFromTValue(float value) => value;

        protected override float GetTValueFromFloat(float value) => value;
    }

}
