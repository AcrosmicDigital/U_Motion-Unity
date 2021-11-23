using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static U.Motion.UAnimation;

namespace U.Motion
{
    public static class SpriteRendererExtension
    {

        public static IAnimatorCore TweenColorR(this SpriteRenderer c, TweenFloat.Properties p)
        {
            p.animate = (x) =>
            {
                var tempColor = c.color;
                tempColor.r = x;
                c.color = tempColor;
            };
            return TweenFloat.AddComponent(c.gameObject, p);
        }

        public static IAnimatorCore TweenColorG(this SpriteRenderer c, TweenFloat.Properties p)
        {
            p.animate = (x) =>
            {
                var tempColor = c.color;
                tempColor.g = x;
                c.color = tempColor;
            };
            return TweenFloat.AddComponent(c.gameObject, p);
        }

        public static IAnimatorCore TweenColorB(this SpriteRenderer c, TweenFloat.Properties p)
        {
            p.animate = (x) =>
            {
                var tempColor = c.color;
                tempColor.b = x;
                c.color = tempColor;
            };
            return TweenFloat.AddComponent(c.gameObject, p);
        }

        public static IAnimatorCore TweenColorA(this SpriteRenderer c, TweenFloat.Properties p)
        {
            p.animate = (x) =>
            {
                var tempColor = c.color;
                tempColor.a = x;
                c.color = tempColor;
            };
            return TweenFloat.AddComponent(c.gameObject, p);
        }



        public static IAnimatorCore TweenColorRG(this SpriteRenderer c, TweenVector2.Properties p)
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

        public static IAnimatorCore TweenColorRB(this SpriteRenderer c, TweenVector2.Properties p)
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

        public static IAnimatorCore TweenColorRA(this SpriteRenderer c, TweenVector2.Properties p)
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

        public static IAnimatorCore TweenColorGB(this SpriteRenderer c, TweenVector2.Properties p)
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

        public static IAnimatorCore TweenColorGA(this SpriteRenderer c, TweenVector2.Properties p)
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

        public static IAnimatorCore TweenColorBA(this SpriteRenderer c, TweenVector2.Properties p)
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






        public static IAnimatorCore TweenColorRGB(this SpriteRenderer c, TweenVector3.Properties p)
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

        public static IAnimatorCore TweenColorRGA(this SpriteRenderer c, TweenVector3.Properties p)
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

        public static IAnimatorCore TweenColorRBA(this SpriteRenderer c, TweenVector3.Properties p)
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

        public static IAnimatorCore TweenColorGBA(this SpriteRenderer c, TweenVector3.Properties p)
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




        public static IAnimatorCore TweenColorRGBA(this SpriteRenderer c, TweenVector4.Properties p)
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
