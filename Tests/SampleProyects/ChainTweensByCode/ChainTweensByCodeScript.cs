using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using U.Motion;

public class ChainTweensByCodeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Tween transform By code
        ChainAnimations();

    }


    private async void ChainAnimations()
    {
        await gameObject.TweenDelay(new Uanimation.TweenEmpty.Properties 
        {
            duration = 6,
        }).Task();

        // Loop this tweens
        while (true)
        {
            await transform.TweenPositionX(new Uanimation.TweenFloat.Properties
            {
                duration = 3,
                keyframes = new Uanimation.TweenFloat.Keyframe[]
            {
                new Uanimation.TweenFloat.Keyframe
                {
                    key = 100,
                    value = 2,
                }
            }
            }).Task();

            await transform.TweenPositionX(new Uanimation.TweenFloat.Properties
            {
                duration = 3,
                keyframes = new Uanimation.TweenFloat.Keyframe[]
                    {
                        new Uanimation.TweenFloat.Keyframe
                        {
                            key = 100,
                            value = 0,
                        }
                    }
            }).Task();

            await transform.TweenScaleXY(new Uanimation.TweenVector2.Properties
            {
                duration = 3,
                direction = Uanimation.Direction.Alternate,
                iterations = 2,
                keyframes = new Uanimation.TweenVector2.Keyframe[]
                {
                    new Uanimation.TweenVector2.Keyframe
                    {
                        key = 100,
                        value = new Vector2(2,2),
                    }
                }
            }).Task();

            await transform.TweenPositionX(new Uanimation.TweenFloat.Properties
            {
                duration = 3,
                keyframes = new Uanimation.TweenFloat.Keyframe[]
                    {
                        new Uanimation.TweenFloat.Keyframe
                        {
                            key = 100,
                            value = -4,
                        }
                    }
            }).Task();
        }

    }

}
