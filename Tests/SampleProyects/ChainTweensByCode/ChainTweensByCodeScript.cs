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
        await gameObject.TweenDelay(new Uanimators.TweenEmpty.Properties 
        {
            duration = 6,
        }).Task();

        // Loop this tweens
        while (true)
        {
            await transform.TweenPositionX(new Uanimators.TweenFloat.Properties
            {
                duration = 3,
                keyframes = new Uanimators.TweenFloat.Keyframe[]
            {
                new Uanimators.TweenFloat.Keyframe
                {
                    key = 100,
                    value = 2,
                }
            }
            }).Task();

            await transform.TweenPositionX(new Uanimators.TweenFloat.Properties
            {
                duration = 3,
                keyframes = new Uanimators.TweenFloat.Keyframe[]
                    {
                        new Uanimators.TweenFloat.Keyframe
                        {
                            key = 100,
                            value = 0,
                        }
                    }
            }).Task();

            await transform.TweenScaleXY(new Uanimators.TweenVector2.Properties
            {
                duration = 3,
                direction = Utween.Direction.Alternate,
                iterations = 2,
                keyframes = new Uanimators.TweenVector2.Keyframe[]
                {
                    new Uanimators.TweenVector2.Keyframe
                    {
                        key = 100,
                        value = new Vector2(2,2),
                    }
                }
            }).Task();

            await transform.TweenPositionX(new Uanimators.TweenFloat.Properties
            {
                duration = 3,
                keyframes = new Uanimators.TweenFloat.Keyframe[]
                    {
                        new Uanimators.TweenFloat.Keyframe
                        {
                            key = 100,
                            value = -4,
                        }
                    }
            }).Task();
        }

    }

}
