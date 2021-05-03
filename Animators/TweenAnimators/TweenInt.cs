using UnityEditor;

namespace U.Motion
{

    public partial class TweenAnimator
    {

        public class TweenInt : TweenAnimatorCore<int> { }


#if UNITY_EDITOR

        [CustomEditor(typeof(TweenInt))]
        public class TweenIntInspectorExtension : TweenAnimatorCoreInspectorExtension { }

#endif
    }

}
