using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace U.Motion
{
    public partial class UAnimation
    {

        public static void DestroyAnimations(GameObject go)
        {
            var anims = go.GetComponents<TimeAnimatorCore>();

            for (int i = 0; i < anims.Length; i++)
            {
                anims[i].DestroyAnimation();
            }
        }

    }
}
