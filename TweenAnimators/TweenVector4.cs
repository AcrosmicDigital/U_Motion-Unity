using UnityEditor;

namespace U.Motion
{

    public class TweenVector4 : TweenAnimator<float, float, float, float> { }


    [CustomEditor(typeof(TweenVector4))]
    public class TweenVector4InspectorExtension : TweenAnimatorCoreInspectorExtension { }

}
