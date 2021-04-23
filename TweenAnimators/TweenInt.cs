using UnityEditor;

namespace U.Motion
{

    public class TweenInt : TweenAnimator<int> { }


    [CustomEditor(typeof(TweenInt))]
    public class TweenIntInspectorExtension : TweenAnimatorCoreInspectorExtension { }

}
