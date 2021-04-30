using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace U.Motion
{
    public static partial class Utween
    {

        [Serializable]
        public struct KeyValueFloat
        {
            public int key;
            public float value;
        }

        [Serializable]
        public struct KeyValueVector2
        {
            public int key;
            public Vector2 value;
        }

        [Serializable]
        public struct KeyValueVector3
        {
            public int key;
            public Vector3 value;
        }


    }
}
