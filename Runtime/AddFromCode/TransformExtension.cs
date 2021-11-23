using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static U.Motion.UAnimation;

namespace U.Motion
{
    public static class TransformExtension
    {

        public static IAnimatorCore TweenPositionX(this Transform t, TweenFloat.Properties p)
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
                            value = t.position.x,
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

            // Add the function to animate the position in x
            p.animate = (x) => t.position = new Vector3(x, t.position.y, t.position.z);

            // Create the tween with added values
            return TweenFloat.AddComponent(t.gameObject, p);

        }


        public static IAnimatorCore TweenPositionY(this Transform t, TweenFloat.Properties p)
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
                            value = t.position.y,
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

            // Add the function to animate the position in x
            p.animate = (y) => t.position = new Vector3(t.position.x, y, t.position.z);

            // Create the tween with added values
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static IAnimatorCore TweenPositionZ(this Transform t, TweenFloat.Properties p)
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
                            value = t.position.z,
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

            // Add the function to animate the position in x
            p.animate = (z) => t.position = new Vector3(t.position.x, t.position.y, z);

            // Create the tween with added values
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static IAnimatorCore TweenPositionXY(this Transform t, TweenVector2.Properties p)
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
                            value = new Vector2(t.position.x, t.position.y),
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

            // Add the function to animate the position in x
            p.animate = (x, y) => t.position = new Vector3(x, y, t.position.z);

            // Create the tween with added values
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static IAnimatorCore TweenPositionXZ(this Transform t, TweenVector2.Properties p)
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
                            value = new Vector2(t.position.x, t.position.z),
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

            // Add the function to animate the position in x
            p.animate = (x, z) => t.position = new Vector3(x, t.position.y, z);

            // Create the tween with added values
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static IAnimatorCore TweenPositionYZ(this Transform t, TweenVector2.Properties p)
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
                            value = new Vector2(t.position.y, t.position.z),
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

            // Add the function to animate the position in x
            p.animate = (y, z) => t.position = new Vector3(t.position.x, y, z);

            // Create the tween with added values
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static IAnimatorCore TweenPositionXYZ(this Transform t, TweenVector3.Properties p)
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
                            value = new Vector3(t.position.x, t.position.y, t.position.z),
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

            // Add the function to animate the position in x
            p.animate = (x, y, z) => t.position = new Vector3(x, y, z);

            // Create the tween with added values
            return TweenVector3.AddComponent(t.gameObject, p);
        }





        public static IAnimatorCore TweenRotationX(this Transform t, TweenFloat.Properties p)
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
                            value = t.rotation.x,
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

            // Add the function to animate the position in x
            p.animate = (x) => t.rotation  = Quaternion.Euler(x, t.rotation.eulerAngles.y, t.rotation.eulerAngles.z);

            // Create the tween with added values
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static IAnimatorCore TweenRotationY(this Transform t, TweenFloat.Properties p)
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
                            value = t.rotation.y,
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

            // Add the function to animate the position in x
            p.animate = (y) => t.rotation  = Quaternion.Euler(t.rotation.eulerAngles.x, y, t.rotation.eulerAngles.z);

            // Create the tween with added values
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static IAnimatorCore TweenRotationZ(this Transform t, TweenFloat.Properties p)
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
                            value = t.rotation.z,
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

            // Add the function to animate the position in x
            p.animate = (z) => t.rotation  = Quaternion.Euler(t.rotation.eulerAngles.x, t.rotation.eulerAngles.y, z);

            // Create the tween with added values
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static IAnimatorCore TweenRotationXY(this Transform t, TweenVector2.Properties p)
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
                            value = new Vector2(t.rotation.x, t.rotation.y),
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

            // Add the function to animate the position in x
            p.animate = (x, y) => t.rotation  = Quaternion.Euler(x, y, t.rotation.eulerAngles.z);

            // Create the tween with added values
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static IAnimatorCore TweenRotationXZ(this Transform t, TweenVector2.Properties p)
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
                            value = new Vector2(t.rotation.x, t.rotation.z),
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

            // Add the function to animate the position in x
            p.animate = (x, z) => t.rotation  = Quaternion.Euler(x, t.rotation.eulerAngles.y, z);

            // Create the tween with added values
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static IAnimatorCore TweenRotationYZ(this Transform t, TweenVector2.Properties p)
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
                            value = new Vector2(t.rotation.y, t.rotation.z),
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

            // Add the function to animate the position in x
            p.animate = (y, z) => t.rotation  = Quaternion.Euler(t.rotation.eulerAngles.x, y, z);

            // Create the tween with added values
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static IAnimatorCore TweenRotationXYZ(this Transform t, TweenVector3.Properties p)
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
                            value = new Vector3(t.rotation.x, t.rotation.y, t.rotation.z),
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

            // Add the function to animate the position in x
            p.animate = (x, y, z) => t.rotation  = Quaternion.Euler(x, y, z);

            // Create the tween with added values
            return TweenVector3.AddComponent(t.gameObject, p);
        }





        public static IAnimatorCore TweenScaleX(this Transform t, TweenFloat.Properties p)
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
                            value = t.localScale.x,
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

            // Add the function to animate the position in x
            p.animate = (x) => t.localScale = new Vector3(x, t.localScale.y, t.localScale.z);

            // Create the tween with added values
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static IAnimatorCore TweenScaleY(this Transform t, TweenFloat.Properties p)
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
                            value = t.localScale.y,
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

            // Add the function to animate the position in x
            p.animate = (y) => t.localScale = new Vector3(t.localScale.x, y, t.localScale.z);

            // Create the tween with added values
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static IAnimatorCore TweenScaleZ(this Transform t, TweenFloat.Properties p)
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
                            value = t.localScale.z,
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

            // Add the function to animate the position in x
            p.animate = (z) => t.localScale = new Vector3(t.localScale.x, t.localScale.y, z);

            // Create the tween with added values
            return TweenFloat.AddComponent(t.gameObject, p);
        }


        public static IAnimatorCore TweenScaleXY(this Transform t, TweenVector2.Properties p)
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
                            value = new Vector2(t.localScale.x, t.localScale.y),
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

            // Add the function to animate the position in x
            p.animate = (x, y) => t.localScale = new Vector3(x, y, t.localScale.z);

            // Create the tween with added values
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static IAnimatorCore TweenScaleXZ(this Transform t, TweenVector2.Properties p)
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
                            value = new Vector2(t.localScale.x, t.localScale.z),
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

            // Add the function to animate the position in x
            p.animate = (x, z) => t.localScale = new Vector3(x, t.localScale.y, z);

            // Create the tween with added values
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static IAnimatorCore TweenScaleYZ(this Transform t, TweenVector2.Properties p)
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
                            value = new Vector2(t.localScale.y, t.localScale.z),
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

            // Add the function to animate the position in x
            p.animate = (y, z) => t.localScale = new Vector3(t.localScale.x, y, z);

            // Create the tween with added values
            return TweenVector2.AddComponent(t.gameObject, p);
        }

        public static IAnimatorCore TweenScaleXYZ(this Transform t, TweenVector3.Properties p)
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
                            value = new Vector3(t.localScale.x, t.localScale.y, t.localScale.z),
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

            // Add the function to animate the position in x
            p.animate = (x, y, z) => t.localScale = new Vector3(x, y, z);

            // Create the tween with added values
            return TweenVector3.AddComponent(t.gameObject, p);
        }
    }
}
