using UnityEditor;
using UnityEngine;
using U.Motion;

namespace U.Motion.Editor
{
    [CustomEditor(typeof(TweenDelay))]
    public class TweenDelayInspector : UnityEditor.Editor
    {

        public override void OnInspectorGUI()
        {
            //base.OnInspectorGUI();

            TweenDelay tweenColor = (TweenDelay)target;

            EditorGUILayout.PropertyField(serializedObject.FindProperty("go"), new GUIContent("GameObject"));

            GUILayout.Space(8);

            var property = serializedObject.FindProperty("tween");
            EditorGUILayout.PropertyField(property, true);

            GUILayout.Space(5);

            serializedObject.ApplyModifiedProperties();

        }
    }
}