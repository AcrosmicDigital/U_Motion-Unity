using UnityEditor;

namespace U.Motion
{

    public class TweenVector2 : TweenAnimator<float, float> { }


    [CustomEditor(typeof(TweenVector2))]
    public class TweenVector2InspectorExtension : TweenAnimatorCoreInspectorExtension { }

}
