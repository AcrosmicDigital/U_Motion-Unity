using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using U.Motion;

#if UNITY_EDITOR

public class TimeAnimatorCoreInspectorExtension : Editor
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

        serializedObject.ApplyModifiedProperties();

    }
}

#endif

