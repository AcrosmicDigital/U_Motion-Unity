
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U.Motion
{
    [Serializable]
    public class ImpulseAnimatorParams
    {
        public float maxValue = 100f;
        public float minValue = -100f;
        public Utween.TimeMode timeMode = Utween.TimeMode.UnscaledDeltaTime;
        public TimeCurve timeCurve = TimeCurve.easeInOut;
        public Utween.FillMode fillMode = Utween.FillMode.Both;
    }
}
