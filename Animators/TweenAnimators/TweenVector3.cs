using UnityEditor;
using UnityEngine;

namespace U.Motion
{

    public partial class TweenAnimator
    {
        public class TweenVector3 : TweenAnimatorCore<float, float, float> { }

#if UNITY_EDITOR

        [CustomEditor(typeof(TweenVector3))]
        public class TweenVector3InspectorExtension : TweenAnimatorCoreInspectorExtension { }

#endif
    }
}