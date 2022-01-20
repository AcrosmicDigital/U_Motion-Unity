using UnityEngine;
using UnityEditor;

namespace U.Motion.Editor
{
    public class VersionMenuButton : EditorWindow
    {

        [MenuItem("Universal/Motion/Version")]
        public static void PrintVersion()
        {

            Debug.Log(" U Framework: Motion v1.0.0 for Unity");

        }

    }
}
