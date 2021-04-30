using UnityEditor;

namespace U.Motion
{

    public class TweenVector4 : TweenAnimator<float, float, float, float> { }

#if UNITY_EDITOR

    [CustomEditor(typeof(TweenVector4))]
    public class TweenVector4InspectorExtension : TweenAnimatorCoreInspectorExtension { }

#endif
}
