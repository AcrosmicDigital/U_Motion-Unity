using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using U.Motion;

#if UNITY_EDITOR

[CustomEditor(typeof(TweenSpriteColor))]
public class TweenSpriteColorInspectorExtension : Editor
{

    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();

        TweenSpriteColor tweenColor = (TweenSpriteColor)target;

        EditorGUILayout.PropertyField(serializedObject.FindProperty("c"), new GUIContent("Sprite Renderer"));

        GUILayout.Space(5);
        
        GUILayout.Label("Color: ");
        EditorGUI.indentLevel++;
        tweenColor.red = EditorGUILayout.Toggle("R", tweenColor.red);
        tweenColor.green = EditorGUILayout.Toggle("G", tweenColor.green);
        tweenColor.blue = EditorGUILayout.Toggle("B", tweenColor.blue);
        tweenColor.alpha = EditorGUILayout.Toggle("A", tweenColor.alpha);
        EditorGUI.indentLevel--;
        
        GUILayout.Space(8);

        if ((tweenColor.red && !tweenColor.green && !tweenColor.blue && !tweenColor.alpha) ||
                    (!tweenColor.red && tweenColor.green && !tweenColor.blue && !tweenColor.alpha) ||
                    (!tweenColor.red && !tweenColor.green && tweenColor.blue && !tweenColor.alpha) ||
                    (!tweenColor.red && !tweenColor.green && !tweenColor.blue && tweenColor.alpha))
        {
            var property = serializedObject.FindProperty("tweenA");
            EditorGUILayout.PropertyField(property, true);
        }

        else if ((tweenColor.red && tweenColor.green && !tweenColor.blue && !tweenColor.alpha) ||
                    (tweenColor.red && !tweenColor.green && tweenColor.blue && !tweenColor.alpha) ||
                    (tweenColor.red && !tweenColor.green && !tweenColor.blue && tweenColor.alpha) ||
                    (!tweenColor.red && tweenColor.green && tweenColor.blue && !tweenColor.alpha) ||
                    (!tweenColor.red && tweenColor.green && !tweenColor.blue && tweenColor.alpha) ||
                    (!tweenColor.red && !tweenColor.green && tweenColor.blue && tweenColor.alpha))
        {
            var property = serializedObject.FindProperty("tweenAB");
            EditorGUILayout.PropertyField(property, true);
        }

        else if ((!tweenColor.red && tweenColor.green && tweenColor.blue && tweenColor.alpha) ||
                    (tweenColor.red && !tweenColor.green && tweenColor.blue && tweenColor.alpha) ||
                    (tweenColor.red && tweenColor.green && !tweenColor.blue && tweenColor.alpha) ||
                    (tweenColor.red && tweenColor.green && tweenColor.blue && !tweenColor.alpha))
        {
            var property = serializedObject.FindProperty("tweenABC");
            EditorGUILayout.PropertyField(property, true);
        }

        else if (tweenColor.red && tweenColor.green && tweenColor.blue && tweenColor.alpha)
        {
            var property = serializedObject.FindProperty("tweenABCD");
            EditorGUILayout.PropertyField(property, true);
        }


        GUILayout.Space(10);

        if (GUILayout.Button("Show Time Curves"))
        {
            TimeCurveEditorWindow window = (TimeCurveEditorWindow)EditorWindow.GetWindow(typeof(TimeCurveEditorWindow), false, "Time Curves");
            window.Show();
        }

        GUILayout.Space(5);

        serializedObject.ApplyModifiedProperties();

    }
}

#endif
