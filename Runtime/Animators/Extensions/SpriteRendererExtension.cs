using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static U.Motion.TweenAnimator;

namespace U.Motion
{
    public static class SpriteRendererExtension
    {

        public static TweenFloat TweenColorR(this SpriteRenderer c, TweenFloat.Properties p)
        {
            p.animate = (x) =>
            {
                var tempColor = c.color;
                tempColor.r = x;
                c.color = tempColor;
            };
            return TweenFloat.AddComponent(c.gameObject, p);
        }

        public static TweenFloat TweenColorG(this SpriteRenderer c, TweenFloat.Properties p)
        {
            p.animate = (x) =>
            {
                var tempColor = c.color;
                tempColor.g = x;
                c.color = tempColor;
            };
            return TweenFloat.AddComponent(c.gameObject, p);
        }

        public static TweenFloat TweenColorB(this SpriteRenderer c, TweenFloat.Properties p)
        {
            p.animate = (x) =>
            {
                var tempColor = c.color;
                tempColor.b = x;
                c.color = tempColor;
            };
            return TweenFloat.AddComponent(c.gameObject, p);
        }

        public static TweenFloat TweenColorA(this SpriteRenderer c, TweenFloat.Properties p)
        {
            p.animate = (x) =>
            {
                var tempColor = c.color;
                tempColor.a = x;
                c.color = tempColor;
            };
            return TweenFloat.AddComponent(c.gameObject, p);
        }



        public static TweenVector2 TweenColorRG(this SpriteRenderer c, TweenVector2.Properties p)
        {
            p.animate = (x, y) =>
            {
                var tempColor = c.color;
                tempColor.r = x;
                tempColor.g = y;
                c.color = tempColor;
            };
            return TweenVector2.AddComponent(c.gameObject, p);
        }

        public static TweenVector2 TweenColorRB(this SpriteRenderer c, TweenVector2.Properties p)
        {
            p.animate = (x, y) =>
            {
                var tempColor = c.color;
                tempColor.r = x;
                tempColor.b = y;
                c.color = tempColor;
            };
            return TweenVector2.AddComponent(c.gameObject, p);

        }

        public static TweenVector2 TweenColorRA(this SpriteRenderer c, TweenVector2.Properties p)
        {
            p.animate = (x, y) =>
            {
                var tempColor = c.color;
                tempColor.r = x;
                tempColor.a = y;
                c.color = tempColor;
            };
            return TweenVector2.AddComponent(c.gameObject, p);
        }

        public static TweenVector2 TweenColorGB(this SpriteRenderer c, TweenVector2.Properties p)
        {
            p.animate = (x, y) =>
            {
                var tempColor = c.color;
                tempColor.g = x;
                tempColor.b = y;
                c.color = tempColor;
            };
            return TweenVector2.AddComponent(c.gameObject, p);
        }

        public static TweenVector2 TweenColorGA(this SpriteRenderer c, TweenVector2.Properties p)
        {
            p.animate = (x, y) =>
            {
                var tempColor = c.color;
                tempColor.g = x;
                tempColor.a = y;
                c.color = tempColor;
            };
            return TweenVector2.AddComponent(c.gameObject, p);
        }

        public static TweenVector2 TweenColorBA(this SpriteRenderer c, TweenVector2.Properties p)
        {
            p.animate = (x, y) =>
            {
                var tempColor = c.color;
                tempColor.b = x;
                tempColor.a = y;
                c.color = tempColor;
            };
            return TweenVector2.AddComponent(c.gameObject, p);
        }






        public static TweenVector3 TweenColorRGB(this SpriteRenderer c, TweenVector3.Properties p)
        {
            p.animate = (x, y, z) =>
            {
                var tempColor = c.color;
                tempColor.r = x;
                tempColor.g = y;
                tempColor.b = y;
                c.color = tempColor;
            };
            return TweenVector3.AddComponent(c.gameObject, p);
        }

        public static TweenVector3 TweenColorRGA(this SpriteRenderer c, TweenVector3.Properties p)
        {
            p.animate = (x, y, z) =>
            {
                var tempColor = c.color;
                tempColor.r = x;
                tempColor.g = y;
                tempColor.a = y;
                c.color = tempColor;
            };
            return TweenVector3.AddComponent(c.gameObject, p);
        }

        public static TweenVector3 TweenColorRBA(this SpriteRenderer c, TweenVector3.Properties p)
        {
            p.animate = (x, y, z) =>
            {
                var tempColor = c.color;
                tempColor.r = x;
                tempColor.b = y;
                tempColor.a = y;
                c.color = tempColor;
            };
            return TweenVector3.AddComponent(c.gameObject, p);
        }

        public static TweenVector3 TweenColorGBA(this SpriteRenderer c, TweenVector3.Properties p)
        {
            p.animate = (x, y, z) =>
            {
                var tempColor = c.color;
                tempColor.g = x;
                tempColor.b = y;
                tempColor.a = y;
                c.color = tempColor;
            };
            return TweenVector3.AddComponent(c.gameObject, p);
        }




        public static TweenVector4 TweenColorRGBA(this SpriteRenderer c, TweenVector4.Properties p)
        {
            p.animate = (x, y, z, w) =>
            {
                var tempColor = c.color;
                tempColor.r = x;
                tempColor.g = y;
                tempColor.b = z;
                tempColor.a = w;
                c.color = tempColor;
            };
            return TweenVector4.AddComponent(c.gameObject, p);
        }

    }
}
