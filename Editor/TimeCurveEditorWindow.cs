using UnityEngine;
using UnityEditor;

namespace U.Motion.Editor
{
    public class TimeCurveEditorWindow : EditorWindow
    {

        [MenuItem("U/Motion/Time Curves")]
        public static void ShowWindow()
        {
            GetWindow<TimeCurveEditorWindow>("Time Curves");
        }


        private void OnGUI()
        {
            GUILayout.Space(10);
            EditorGUILayout.CurveField("Linear", TimeCurve.linear);

            GUILayout.Space(10);
            EditorGUILayout.CurveField("EaseIn", TimeCurve.easeIn);
            EditorGUILayout.CurveField("EaseOut", TimeCurve.easeOut);
            EditorGUILayout.CurveField("EaseInOut", TimeCurve.easeInOut);

            GUILayout.Space(10);
            EditorGUILayout.CurveField("CircIn", TimeCurve.circIn);
            EditorGUILayout.CurveField("CircOut", TimeCurve.circOut);
            EditorGUILayout.CurveField("CircInOut", TimeCurve.circInOut);

            GUILayout.Space(10);
            EditorGUILayout.CurveField("BounceIn", TimeCurve.bounceIn);
            EditorGUILayout.CurveField("BounceOut", TimeCurve.bounceOut);
            EditorGUILayout.CurveField("BounceInOut", TimeCurve.bounceInOut);

            GUILayout.Space(10);
            EditorGUILayout.CurveField("ElasticIn", TimeCurve.elasticIn);
            EditorGUILayout.CurveField("ElasticOut", TimeCurve.elasticOut);
            EditorGUILayout.CurveField("ElasticInOut", TimeCurve.elasticInOut);

            GUILayout.Space(10);
            EditorGUILayout.CurveField("Fast", TimeCurve.fast);
            EditorGUILayout.CurveField("Sine", TimeCurve.sine);
            EditorGUILayout.CurveField("Bisine", TimeCurve.bisine);

        }

    }
}