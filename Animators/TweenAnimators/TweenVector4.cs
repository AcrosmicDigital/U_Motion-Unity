using UnityEditor;

namespace U.Motion
{
    public partial class TweenAnimator
    {
        public class TweenVector4 : TweenAnimatorCore<float, float, float, float> { }

#if UNITY_EDITOR

        [CustomEditor(typeof(TweenVector4))]
        public class TweenVector4InspectorExtension : TweenAnimatorCoreInspectorExtension { }

#endif
    }
}
