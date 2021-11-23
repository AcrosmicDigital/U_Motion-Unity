using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static U.Motion.UAnimation;

namespace U.Motion
{
    public static class GameObjectExension
    {
        public static IAnimatorCore TweenDelay(this GameObject go, TweenEmpty.Properties p)
        { 


            // Create the tween with added values
            return UAnimation.TweenEmpty.AddComponent(go, p);

        }

        public static void DestroyAnimations(this GameObject go) => UAnimation.DestroyAnimations(go);

    }
}
