using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U.Motion
{

    // Provada

    [Serializable]
    public class TimeAnimationParams
    {

        public float duration = 2;
        public int iterations = 1;
        public float delay = 0;
        public Utween.Direction direction = Utween.Direction.Normal;
        public Utween.FillMode fillMode = Utween.FillMode.Both;
        public EaseCurve timingCurve = EaseCurve.easeInOut;
        public Utween.TimeMode timeMode = Utween.TimeMode.UnscaledDeltaTime;
        public Utween.OnCompleteMode onCompleteMode = Utween.OnCompleteMode.Disable;

    }

}
