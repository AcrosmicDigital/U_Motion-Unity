using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using U.Motion;

#if UNITY_EDITOR

[CustomEditor(typeof(TweenTransform))]

public class TweenTransformInspectorExtension : Editor
{

    protected bool showPosition = false;
    protected bool showRotation = false;
    protected bool showScale = false;




    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();

        TweenTransform tweenTransform = (TweenTransform)target;

        EditorGUILayout.PropertyField(serializedObject.FindProperty("t"), new GUIContent("Transform"));

        GUILayout.Space(10);

        showPosition = EditorGUILayout.Foldout(showPosition, "Tween Position");
        if (showPosition)
        {
            EditorGUI.indentLevel++;
            tweenTransform.tweenPosition = EditorGUILayout.Toggle("Enabled", tweenTransform.tweenPosition);
            if (tweenTransform.tweenPosition)
            {
                EditorGUI.indentLevel++;
                tweenTransform.positionX = EditorGUILayout.Toggle("X", tweenTransform.positionX);
                tweenTransform.positionY = EditorGUILayout.Toggle("Y", tweenTransform.positionY);
                tweenTransform.positionZ = EditorGUILayout.Toggle("Z", tweenTransform.positionZ);
                EditorGUI.indentLevel--;

                GUILayout.Space(8);

                // A
                if ((tweenTransform.positionX && !tweenTransform.positionY && !tweenTransform.positionZ) ||
                    (!tweenTransform.positionX && tweenTransform.positionY && !tweenTransform.positionZ) ||
                    (!tweenTransform.positionX && !tweenTransform.positionY && tweenTransform.positionZ))
                {
                    var property = serializedObject.FindProperty("positionTweenA");
                    EditorGUILayout.PropertyField(property, true);
                }

                // AB
                if ((tweenTransform.positionX && tweenTransform.positionY && !tweenTransform.positionZ) ||
                    (tweenTransform.positionX && !tweenTransform.positionY && tweenTransform.positionZ) ||
                    (!tweenTransform.positionX && tweenTransform.positionY && tweenTransform.positionZ))
                {
                    var property = serializedObject.FindProperty("positionTweenAB");
                    EditorGUILayout.PropertyField(property, true);
                }

                // ABC
                if ((tweenTransform.positionX && tweenTransform.positionY && tweenTransform.positionZ))
                {
                    var property = serializedObject.FindProperty("positionTweenABC");
                    EditorGUILayout.PropertyField(property, true);
                }

            }
            EditorGUI.indentLevel--;
        }

        GUILayout.Space(6);
        GUILayout.Label("______________________________________________________________________________________________________________________________________________________");

        showRotation = EditorGUILayout.Foldout(showRotation, "Tween Rotation");
        if (showRotation)
        {
            EditorGUI.indentLevel++;
            tweenTransform.tweenRotation = EditorGUILayout.Toggle("Enabled", tweenTransform.tweenRotation);
            if (tweenTransform.tweenRotation)
            {
                EditorGUI.indentLevel++;
                tweenTransform.rotationX = EditorGUILayout.Toggle("X", tweenTransform.rotationX);
                tweenTransform.rotationY = EditorGUILayout.Toggle("Y", tweenTransform.rotationY);
                tweenTransform.rotationZ = EditorGUILayout.Toggle("Z", tweenTransform.rotationZ);
                EditorGUI.indentLevel--;

                GUILayout.Space(8);

                // A
                if ((tweenTransform.rotationX && !tweenTransform.rotationY && !tweenTransform.rotationZ) ||
                    (!tweenTransform.rotationX && tweenTransform.rotationY && !tweenTransform.rotationZ) ||
                    (!tweenTransform.rotationX && !tweenTransform.rotationY && tweenTransform.rotationZ))
                {
                    var property = serializedObject.FindProperty("rotationTweenA");
                    EditorGUILayout.PropertyField(property, true);
                }

                // AB
                if ((tweenTransform.rotationX && tweenTransform.rotationY && !tweenTransform.rotationZ) ||
                    (tweenTransform.rotationX && !tweenTransform.rotationY && tweenTransform.rotationZ) ||
                    (!tweenTransform.rotationX && tweenTransform.rotationY && tweenTransform.rotationZ))
                {
                    var property = serializedObject.FindProperty("rotationTweenAB");
                    EditorGUILayout.PropertyField(property, true);
                }

                // ABC
                if ((tweenTransform.rotationX && tweenTransform.rotationY && tweenTransform.rotationZ))
                {
                    var property = serializedObject.FindProperty("rotationTweenABC");
                    EditorGUILayout.PropertyField(property, true);
                }

            }
            EditorGUI.indentLevel--;
        }

        GUILayout.Space(6);
        GUILayout.Label("______________________________________________________________________________________________________________________________________________________");

        showScale = EditorGUILayout.Foldout(showScale, "Tween Scale");
        if (showScale)
        {
            EditorGUI.indentLevel++;
            tweenTransform.tweenScale = EditorGUILayout.Toggle("Enabled", tweenTransform.tweenScale);
            if (tweenTransform.tweenScale)
            {
                EditorGUI.indentLevel++;
                tweenTransform.scaleX = EditorGUILayout.Toggle("X", tweenTransform.scaleX);
                tweenTransform.scaleY = EditorGUILayout.Toggle("Y", tweenTransform.scaleY);
                tweenTransform.scaleZ = EditorGUILayout.Toggle("Z", tweenTransform.scaleZ);
                EditorGUI.indentLevel--;

                GUILayout.Space(8);

                // A
                if ((tweenTransform.scaleX && !tweenTransform.scaleY && !tweenTransform.scaleZ) ||
                    (!tweenTransform.scaleX && tweenTransform.scaleY && !tweenTransform.scaleZ) ||
                    (!tweenTransform.scaleX && !tweenTransform.scaleY && tweenTransform.scaleZ))
                {
                    var property = serializedObject.FindProperty("scaleTweenA");
                    EditorGUILayout.PropertyField(property, true);
                }

                // AB
                if ((tweenTransform.scaleX && tweenTransform.scaleY && !tweenTransform.scaleZ) ||
                    (tweenTransform.scaleX && !tweenTransform.scaleY && tweenTransform.scaleZ) ||
                    (!tweenTransform.scaleX && tweenTransform.scaleY && tweenTransform.scaleZ))
                {
                    var property = serializedObject.FindProperty("scaleTweenAB");
                    EditorGUILayout.PropertyField(property, true);
                }

                // ABC
                if ((tweenTransform.scaleX && tweenTransform.scaleY && tweenTransform.scaleZ))
                {
                    var property = serializedObject.FindProperty("scaleTweenABC");
                    EditorGUILayout.PropertyField(property, true);
                }

            }
            EditorGUI.indentLevel--;
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