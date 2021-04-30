using UnityEditor;

namespace U.Motion
{

    public class TweenFloat : TweenAnimator<float> { }


#if UNITY_EDITOR

    [CustomEditor(typeof(TweenFloat))]
    public class TweenFloatInspectorExtension : TweenAnimatorCoreInspectorExtension { }

#endif

}

