﻿using UnityEditor;
using UnityEngine;
using U.Motion;

namespace U.Motion.Editor
{
    [CustomEditor(typeof(TweenTransformLocalPosition))]
    public class TweenTransformLocalPositionInspector : UnityEditor.Editor
    {

        public override void OnInspectorGUI()
        {

            TweenTransformLocalPosition tweenTransform = (TweenTransformLocalPosition)target;

            EditorGUILayout.PropertyField(serializedObject.FindProperty("t"), new GUIContent("Transform"));

            GUILayout.Space(10);

            EditorGUI.indentLevel++;
            EditorGUI.indentLevel++;
            tweenTransform.x = EditorGUILayout.Toggle("X", tweenTransform.x);
            tweenTransform.y = EditorGUILayout.Toggle("Y", tweenTransform.y);
            tweenTransform.z = EditorGUILayout.Toggle("Z", tweenTransform.z);
            EditorGUI.indentLevel--;

            GUILayout.Space(8);

            // A
            if ((tweenTransform.x && !tweenTransform.y && !tweenTransform.z) ||
                (!tweenTransform.x && tweenTransform.y && !tweenTransform.z) ||
                (!tweenTransform.x && !tweenTransform.y && tweenTransform.z))
            {
                var property = serializedObject.FindProperty("tweenA");
                EditorGUILayout.PropertyField(property, true);
            }

            // AB
            if ((tweenTransform.x && tweenTransform.y && !tweenTransform.z) ||
                (tweenTransform.x && !tweenTransform.y && tweenTransform.z) ||
                (!tweenTransform.x && tweenTransform.y && tweenTransform.z))
            {
                var property = serializedObject.FindProperty("tweenAB");
                EditorGUILayout.PropertyField(property, true);
            }

            // ABC
            if ((tweenTransform.x && tweenTransform.y && tweenTransform.z))
            {
                var property = serializedObject.FindProperty("tweenABC");
                EditorGUILayout.PropertyField(property, true);
            }
            EditorGUI.indentLevel--;

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
}