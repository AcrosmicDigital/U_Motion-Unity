using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static U.Motion.TweenAnimator;

namespace U.Motion
{
    public static class TransformExtension
    {

        public static TweenFloat TweenPositionX(this Transform t, TweenFloat.Properties p)
        {
            p.animate = (x) => t.position = new Vector3(x, t.position.y, t.position.z);
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static TweenFloat TweenPositionY(this Transform t, TweenFloat.Properties p)
        {
            p.animate = (y) => t.position = new Vector3(t.position.x, y, t.position.z);
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static TweenFloat TweenPositionZ(this Transform t, TweenFloat.Properties p)
        {
            p.animate = (z) => t.position = new Vector3(t.position.x, t.position.y, z);
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static TweenVector2 TweenPositionXY(this Transform t, TweenVector2.Properties p)
        {
            p.animate = (x, y) => t.position = new Vector3(x, y, t.position.z);
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static TweenVector2 TweenPositionXZ(this Transform t, TweenVector2.Properties p)
        {
            p.animate = (x, z) => t.position = new Vector3(x, t.position.y, z);
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static TweenVector2 TweenPositionYZ(this Transform t, TweenVector2.Properties p)
        {
            p.animate = (y, z) => t.position = new Vector3(t.position.x, y, z);
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static TweenVector3 TweenPositionXYZ(this Transform t, TweenVector3.Properties p)
        {
            p.animate = (x, y, z) => t.position = new Vector3(x, y, z);
            return TweenVector3.AddComponent(t.gameObject, p);
        }





        public static TweenFloat TweenRotationX(this Transform t, TweenFloat.Properties p)
        {
            p.animate = (x) => t.rotation  = Quaternion.Euler(x, t.rotation.eulerAngles.y, t.rotation.eulerAngles.z);
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static TweenFloat TweenRotationY(this Transform t, TweenFloat.Properties p)
        {
            p.animate = (y) => t.rotation  = Quaternion.Euler(t.rotation.eulerAngles.x, y, t.rotation.eulerAngles.z);
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static TweenFloat TweenRotationZ(this Transform t, TweenFloat.Properties p)
        {
            p.animate = (z) => t.rotation  = Quaternion.Euler(t.rotation.eulerAngles.x, t.rotation.eulerAngles.y, z);
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static TweenVector2 TweenRotationXY(this Transform t, TweenVector2.Properties p)
        {
            p.animate = (x, y) => t.rotation  = Quaternion.Euler(x, y, t.rotation.eulerAngles.z);
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static TweenVector2 TweenRotationXZ(this Transform t, TweenVector2.Properties p)
        {
            p.animate = (x, z) => t.rotation  = Quaternion.Euler(x, t.rotation.eulerAngles.y, z);
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static TweenVector2 TweenRotationYZ(this Transform t, TweenVector2.Properties p)
        {
            p.animate = (y, z) => t.rotation  = Quaternion.Euler(t.rotation.eulerAngles.x, y, z);
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static TweenVector3 TweenRotationXYZ(this Transform t, TweenVector3.Properties p)
        {
            p.animate = (x, y, z) => t.rotation  = Quaternion.Euler(x, y, z);
            return TweenVector3.AddComponent(t.gameObject, p);
        }





        public static TweenFloat TweenScaleX(this Transform t, TweenFloat.Properties p)
        {
            p.animate = (x) => t.localScale = new Vector3(x, t.localScale.y, t.localScale.z);
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static TweenFloat TweenScaleY(this Transform t, TweenFloat.Properties p)
        {
            p.animate = (y) => t.localScale = new Vector3(t.localScale.x, y, t.localScale.z);
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static TweenFloat TweenScaleZ(this Transform t, TweenFloat.Properties p)
        {
            p.animate = (z) => t.localScale = new Vector3(t.localScale.x, t.localScale.y, z);
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static TweenVector2 TweenScaleXY(this Transform t, TweenVector2.Properties p)
        {
            p.animate = (x, y) => t.localScale = new Vector3(x, y, t.localScale.z);
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static TweenVector2 TweenScaleXZ(this Transform t, TweenVector2.Properties p)
        {
            p.animate = (x, z) => t.localScale = new Vector3(x, t.localScale.y, z);
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static TweenVector2 TweenScaleYZ(this Transform t, TweenVector2.Properties p)
        {
            p.animate = (y, z) => t.localScale = new Vector3(t.localScale.x, y, z);
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static TweenVector3 TweenScaleXYZ(this Transform t, TweenVector3.Properties p)
        {
            p.animate = (x, y, z) => t.localScale = new Vector3(x, y, z);
            return TweenVector3.AddComponent(t.gameObject, p);
        }
    }
}
