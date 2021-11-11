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

        public static IanimatorCore TweenColorR(this SpriteRenderer c, TweenFloat.Properties p)
        {
            p.animate = (x) =>
            {
                var tempColor = c.color;
                tempColor.r = x;
                c.color = tempColor;
            };
            return TweenFloat.AddComponent(c.gameObject, p);
        }

        public static IanimatorCore TweenColorG(this SpriteRenderer c, TweenFloat.Properties p)
        {
            p.animate = (x) =>
            {
                var tempColor = c.color;
                tempColor.g = x;
                c.color = tempColor;
            };
            return TweenFloat.AddComponent(c.gameObject, p);
        }

        public static IanimatorCore TweenColorB(this SpriteRenderer c, TweenFloat.Properties p)
        {
            p.animate = (x) =>
            {
                var tempColor = c.color;
                tempColor.b = x;
                c.color = tempColor;
            };
            return TweenFloat.AddComponent(c.gameObject, p);
        }

        public static IanimatorCore TweenColorA(this SpriteRenderer c, TweenFloat.Properties p)
        {
            p.animate = (x) =>
            {
                var tempColor = c.color;
                tempColor.a = x;
                c.color = tempColor;
            };
            return TweenFloat.AddComponent(c.gameObject, p);
        }



        public static IanimatorCore TweenColorRG(this SpriteRenderer c, TweenVector2.Properties p)
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

        public static IanimatorCore TweenColorRB(this SpriteRenderer c, TweenVector2.Properties p)
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

        public static IanimatorCore TweenColorRA(this SpriteRenderer c, TweenVector2.Properties p)
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

        public static IanimatorCore TweenColorGB(this SpriteRenderer c, TweenVector2.Properties p)
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

        public static IanimatorCore TweenColorGA(this SpriteRenderer c, TweenVector2.Properties p)
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

        public static IanimatorCore TweenColorBA(this SpriteRenderer c, TweenVector2.Properties p)
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






        public static IanimatorCore TweenColorRGB(this SpriteRenderer c, TweenVector3.Properties p)
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

        public static IanimatorCore TweenColorRGA(this SpriteRenderer c, TweenVector3.Properties p)
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

        public static IanimatorCore TweenColorRBA(this SpriteRenderer c, TweenVector3.Properties p)
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

        public static IanimatorCore TweenColorGBA(this SpriteRenderer c, TweenVector3.Properties p)
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




        public static IanimatorCore TweenColorRGBA(this SpriteRenderer c, TweenVector4.Properties p)
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
