using UnityEditor;

namespace U.Motion
{

    public class TweenInt : TweenAnimator<int> { }


#if UNITY_EDITOR

    [CustomEditor(typeof(TweenInt))]
    public class TweenIntInspectorExtension : TweenAnimatorCoreInspectorExtension { }

#endif

}
