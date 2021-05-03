using UnityEditor;

namespace U.Motion
{

    public partial class TweenAnimator
    {

        public class TweenVector2 : TweenAnimatorCore<float, float> { }


#if UNITY_EDITOR

        [CustomEditor(typeof(TweenVector2))]
        public class TweenVector2InspectorExtension : TweenAnimatorCoreInspectorExtension { }

#endif
    }
}
