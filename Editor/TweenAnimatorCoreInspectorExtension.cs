using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace U.Motion
{

    // Provada


    public class TweenAnimatorCoreInspectorExtension : Editor
    {

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            TimeAnimatorCore tweenCore = (TimeAnimatorCore)target;

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

        }
    }
}
