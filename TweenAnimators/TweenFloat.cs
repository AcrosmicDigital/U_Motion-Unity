using UnityEditor;

namespace U.Motion
{

    public class TweenFloat : TweenAnimator<float> { }


    [CustomEditor(typeof(TweenFloat))]
    public class TweenFloatInspectorExtension : TweenAnimatorCoreInspectorExtension { }

}

