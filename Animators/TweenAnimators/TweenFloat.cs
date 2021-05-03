using UnityEditor;

namespace U.Motion
{

    public partial class TweenAnimator
    {
        public class TweenFloat : TweenAnimatorCore<float> { }

#if UNITY_EDITOR

        [CustomEditor(typeof(TweenFloat))]
        public class TweenFloatInspectorExtension : TweenAnimatorCoreInspectorExtension { }

#endif

    }





}

