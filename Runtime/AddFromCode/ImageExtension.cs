using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using static U.Motion.UAnimation;

namespace U.Motion
{
    public static class ImageExtension
    {

        public static IAnimatorCore TweenColorR(this  Image c, TweenFloat.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenFloat.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenFloat.Keyframe
                        {
                            key = 0,
                            value = c.color.r,
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            p.animate = (x) =>
            {
                var tempColor = c.color;
                tempColor.r = x;
                c.color = tempColor;
            };

            return TweenFloat.AddComponent(c.gameObject, p);
        }

        public static IAnimatorCore TweenColorG(this Image c, TweenFloat.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenFloat.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenFloat.Keyframe
                        {
                            key = 0,
                            value = c.color.g,
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            p.animate = (x) =>
            {
                var tempColor = c.color;
                tempColor.g = x;
                c.color = tempColor;
            };

            return TweenFloat.AddComponent(c.gameObject, p);
        }

        public static IAnimatorCore TweenColorB(this Image c, TweenFloat.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenFloat.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenFloat.Keyframe
                        {
                            key = 0,
                            value = c.color.b,
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            p.animate = (x) =>
            {
                var tempColor = c.color;
                tempColor.b = x;
                c.color = tempColor;
            };

            return TweenFloat.AddComponent(c.gameObject, p);
        }

        public static IAnimatorCore TweenColorA(this Image c, TweenFloat.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenFloat.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenFloat.Keyframe
                        {
                            key = 0,
                            value = c.color.a,
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            p.animate = (x) =>
            {
                var tempColor = c.color;
                tempColor.a = x;
                c.color = tempColor;
            };

            return TweenFloat.AddComponent(c.gameObject, p);
        }



        public static IAnimatorCore TweenColorRG(this Image c, TweenVector2.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenVector2.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenVector2.Keyframe
                        {
                            key = 0,
                            value = new Vector2(c.color.r, c.color.g),
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            p.animate = (x, y) =>
            {
                var tempColor = c.color;
                tempColor.r = x;
                tempColor.g = y;
                c.color = tempColor;
            };

            return TweenVector2.AddComponent(c.gameObject, p);
        }

        public static IAnimatorCore TweenColorRB(this Image c, TweenVector2.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenVector2.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenVector2.Keyframe
                        {
                            key = 0,
                            value = new Vector2(c.color.r, c.color.b),
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            p.animate = (x, y) =>
            {
                var tempColor = c.color;
                tempColor.r = x;
                tempColor.b = y;
                c.color = tempColor;
            };

            return TweenVector2.AddComponent(c.gameObject, p);

        }

        public static IAnimatorCore TweenColorRA(this Image c, TweenVector2.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenVector2.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenVector2.Keyframe
                        {
                            key = 0,
                            value = new Vector2(c.color.r, c.color.a),
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            p.animate = (x, y) =>
            {
                var tempColor = c.color;
                tempColor.r = x;
                tempColor.a = y;
                c.color = tempColor;
            };

            return TweenVector2.AddComponent(c.gameObject, p);
        }

        public static IAnimatorCore TweenColorGB(this Image c, TweenVector2.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenVector2.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenVector2.Keyframe
                        {
                            key = 0,
                            value = new Vector2(c.color.g, c.color.b),
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            p.animate = (x, y) =>
            {
                var tempColor = c.color;
                tempColor.g = x;
                tempColor.b = y;
                c.color = tempColor;
            };

            return TweenVector2.AddComponent(c.gameObject, p);
        }

        public static IAnimatorCore TweenColorGA(this Image c, TweenVector2.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenVector2.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenVector2.Keyframe
                        {
                            key = 0,
                            value = new Vector2(c.color.g, c.color.a),
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            p.animate = (x, y) =>
            {
                var tempColor = c.color;
                tempColor.g = x;
                tempColor.a = y;
                c.color = tempColor;
            };

            return TweenVector2.AddComponent(c.gameObject, p);
        }

        public static IAnimatorCore TweenColorBA(this Image c, TweenVector2.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenVector2.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenVector2.Keyframe
                        {
                            key = 0,
                            value = new Vector2(c.color.b, c.color.a),
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

            p.animate = (x, y) =>
            {
                var tempColor = c.color;
                tempColor.b = x;
                tempColor.a = y;
                c.color = tempColor;
            };

            return TweenVector2.AddComponent(c.gameObject, p);
        }






        public static IAnimatorCore TweenColorRGB(this Image c, TweenVector3.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenVector3.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenVector3.Keyframe
                        {
                            key = 0,
                            value = new Vector3(c.color.r, c.color.g, c.color.b),
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

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

        public static IAnimatorCore TweenColorRGA(this Image c, TweenVector3.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenVector3.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenVector3.Keyframe
                        {
                            key = 0,
                            value = new Vector3(c.color.r, c.color.g, c.color.a),
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

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

        public static IAnimatorCore TweenColorRBA(this Image c, TweenVector3.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenVector3.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenVector3.Keyframe
                        {
                            key = 0,
                            value = new Vector3(c.color.r, c.color.b, c.color.a),
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

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

        public static IAnimatorCore TweenColorGBA(this Image c, TweenVector3.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenVector3.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenVector3.Keyframe
                        {
                            key = 0,
                            value = new Vector3(c.color.g, c.color.b, c.color.a),
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

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




        public static IAnimatorCore TweenColorRGBA(this Image c, TweenVector4.Properties p)
        {
            // If no start keyframe, use the current position as first frame
            if (p.keyframes != null)
            {
                if (p.keyframes.Length > 0)
                {
                    if (p.keyframes[0].key != 0)
                    {
                        var newKeys = new TweenVector4.Keyframe[p.keyframes.Length + 1];

                        // First key is actual position
                        newKeys[0] = new TweenVector4.Keyframe
                        {
                            key = 0,
                            value = new Vector4(c.color.r, c.color.g, c.color.b, c.color.a),
                        };

                        // Add the others keys
                        for (int i = 0; i < p.keyframes.Length; i++)
                        {
                            newKeys[i + 1] = p.keyframes[i];
                        }

                        // Set the new list of frames
                        p.keyframes = newKeys;

                    }
                }
            }

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
