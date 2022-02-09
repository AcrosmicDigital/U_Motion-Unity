using UnityEditor;
using static U.Universal.Scenes.Editor.UE;

namespace U.Universal.Scenes.Editor
{
    public class CreateMotionByCodeMenuButton : EditorWindow
    {

        #region File
        private static string DefaultFolderName => "/Scripts/MotionByCode/";
        private static string DefaultFileName => "New";
        private static string CustomExtension => "mobyco";
        static string[] file(string fileName) => new string[]
        {
            "using System;",
            "using U.Motion;",
            "using UnityEngine;",
            "using System.Threading.Tasks;",
            "",
            "public static partial class MotionByCode",
            "{",
            "    public static partial class "+fileName+"",
            "    {",
            "",
            "",
            "        // Statics",
            "        // static GameObject animPlanet;  // Example",
            "        // ...",
            "",
            "",
            "        // Find References",
            "        private static void FindReferences()",
            "        {",
            "            // Here find all the statics references",
            "            // animPlanet = AnimationSceneManager.S.planet;  // Example",
            "            // ...",
            "        }",
            "",
            "",
            "        // Skip the animation",
            "        public static async Task Skip(Action onComplete)",
            "        {",
            "",
            "            // Get the references",
            "            FindReferences();",
            "",
            "            // Write animation here",
            "            await Task.Run(() => { }); // Erase this",
            "            // ...",
            "",
            "            // Invoke OnComplete",
            "            onComplete?.Invoke();",
            "",
            "        }",
            "",
            "        // Play the animation",
            "        public static async Task Play(Action onComplete)",
            "        {",
            "",
            "            // Get the references",
            "            FindReferences();",
            "",
            "            // Write animation here",
            "            await Task.Run(() => { }); // Erase this",
            "            // ...",
            "",
            "            // Invoke OnComplete",
            "            onComplete?.Invoke();",
            "",
            "        }",
            "",
            "    }",
            "}",
        };
        #endregion File



        private static string FormatLog(string text) => "UniversalScenes: " + text;


        [MenuItem("Universal/Motion/Create/Motion By Code")]
        public static void ShowWindow()
        {

            // Create files
            CreateFileWithSaveFilePanelAndCustomExtension(DefaultFolderName, DefaultFileName, file, FormatLog, CustomExtension);

            // Compile
            AssetDatabase.Refresh();

        }

    }
}