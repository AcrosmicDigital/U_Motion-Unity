using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace U.Motion
{

    // Probada

    public class DoubleKeysCurve : KeysCurve<double>
    {
        public DoubleKeysCurve(Dictionary<int, double> keys, Utween.KeysCurveMode curveMode) : base(keys, curveMode) { }

        protected override float GetFloatFromTValue(double value) => (float)value;

        protected override double GetTValueFromFloat(float value) => (double)value;
    }

}
