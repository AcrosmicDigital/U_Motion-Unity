using UnityEditor;
using UnityEngine;

namespace U.Motion.Editor
{
    public class TimeAnimatorCoreInspector : UnityEditor.Editor
    {

        public override void OnInspectorGUI()
        {
            //base.OnInspectorGUI();
            TimeAnimatorCore tweenCore = (TimeAnimatorCore)target;

            SerializedProperty properties = serializedObject.GetIterator();
            if (properties.NextVisible(true))
            {
                do
                {
                    EditorGUILayout.PropertyField(serializedObject.FindProperty(properties.name), true);
                }
                while (properties.NextVisible(false));
            }


            GUILayout.Space(10);
            GUILayout.Label("Progress: " + tweenCore.Progress + "%");
            GUILayout.Space(4);
            GUILayout.Label("Animation Curves");
            GUILayout.Space(4);

            int i = 0;
            foreach (var curve in tweenCore.GetCurves())
            {
                if (i == 0)
                {
                    if (curve != null)
                        EditorGUILayout.CurveField("TimingCurve", curve);
                }
                else
                {
                    if (curve != null)
                        EditorGUILayout.CurveField("KeysCurve" + i, curve);
                }


                i++;
            }

            // serializedObject.ApplyModifiedProperties();

        }

    }
}

