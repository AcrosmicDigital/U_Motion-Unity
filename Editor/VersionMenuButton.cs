using UnityEngine;
using UnityEditor;


#if UNITY_EDITOR

public class VersionMenuButton : EditorWindow
{

    [MenuItem("U/Motion/Version")]
    public static void PrintVersion()
    {

        Debug.Log(" U Framework: Motion v1.0.0 for Unity");

    }
}


#endif
