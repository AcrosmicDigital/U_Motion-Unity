using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace U.Motion
{

    // Probada

    public class IntKeysCurve : KeysCurve<int>
    {
        public IntKeysCurve(Dictionary<int, int> keys, Utween.KeysCurveMode curveMode) : base(keys, curveMode) { }

        protected override float GetFloatFromTValue(int value) => (float)value;

        protected override int GetTValueFromFloat(float value) => (int)value;
    }

}