using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using U.Motion;

public class TweenTransformByCodeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Tween transform By code
        ChainAnimations();

    }


    private async void ChainAnimations()
    {
        await transform.TweenPositionX(new TweenAnimator.TweenFloat.Properties
        {
            delay = 6,
            duration = 3,
            keyframes = new TweenAnimator.TweenFloat.Keyframe[]
            {
                new TweenAnimator.TweenFloat.Keyframe
                {
                    key = 100,
                    value = 2,
                }
            }
        }).Task();

        await transform.TweenPositionX(new TweenAnimator.TweenFloat.Properties
        {
            duration = 3,
            keyframes = new TweenAnimator.TweenFloat.Keyframe[]
                {
                    new TweenAnimator.TweenFloat.Keyframe
                    {
                        key = 100,
                        value = 0,
                    }
                }
        }).Task();

        await transform.TweenScaleXY(new TweenAnimator.TweenVector2.Properties
        {
            duration = 3,
            keyframes = new TweenAnimator.TweenVector2.Keyframe[]
            {
                new TweenAnimator.TweenVector2.Keyframe
                {
                    key = 100,
                    value = new Vector2(2,2),
                }
            }
        }).Task();

    }

}
