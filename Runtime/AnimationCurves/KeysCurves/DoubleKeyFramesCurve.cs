using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace U.Motion
{

    // Probada

    public class DoubleKeyFramesCurve : KeyFramesCurve<double>
    {
        public DoubleKeyFramesCurve(Dictionary<int, double> keys, Uanimation.KeysCurveMode curveMode) : base(keys, curveMode) { }

        protected override float GetFloatFromTValue(double value) => (float)value;

        protected override double GetTValueFromFloat(float value) => (double)value;
    }

}
