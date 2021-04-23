using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using U.Motion;


public class TimeCurveEditorWindow : EditorWindow
{
    
    [MenuItem("Universal/Motion/Easing Functions")]
    public static void ShowWindow()
    {
        GetWindow<TimeCurveEditorWindow>("Easing Functions");
    }


    private void OnGUI()
    {
        GUILayout.Space(10);
        EditorGUILayout.CurveField("Linear", EaseCurve.linear);

        GUILayout.Space(10);
        EditorGUILayout.CurveField("EaseIn", EaseCurve.easeIn);
        EditorGUILayout.CurveField("EaseOut", EaseCurve.easeOut);
        EditorGUILayout.CurveField("EaseInOut", EaseCurve.easeInOut);

        GUILayout.Space(10);
        EditorGUILayout.CurveField("CircIn", EaseCurve.circIn);
        EditorGUILayout.CurveField("CircOut", EaseCurve.circOut);
        EditorGUILayout.CurveField("CircInOut", EaseCurve.circInOut);

        GUILayout.Space(10);
        EditorGUILayout.CurveField("BounceIn", EaseCurve.bounceIn);
        EditorGUILayout.CurveField("BounceOut", EaseCurve.bounceOut);
        EditorGUILayout.CurveField("BounceInOut", EaseCurve.bounceInOut);

        GUILayout.Space(10);
        EditorGUILayout.CurveField("ElasticIn", EaseCurve.elasticIn);
        EditorGUILayout.CurveField("ElasticOut", EaseCurve.elasticOut);
        EditorGUILayout.CurveField("ElasticInOut", EaseCurve.elasticInOut);

    }

}
