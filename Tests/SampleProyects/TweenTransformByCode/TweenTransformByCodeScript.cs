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
        transform.TweenPositionY(new UAnimation.TweenFloat.Properties
        {
            delay = 6,
            duration = 2,
            direction = UAnimation.Direction.Alternate,
            onCompleteMode = UAnimation.OnCompleteMode.Loop,
            keyframes = new UAnimation.TweenFloat.Keyframe[]
            {
                new UAnimation.TweenFloat.Keyframe
                {
                    key = 100,
                    value = 3,
                }
            }
        });

        // Tween transform By code
        transform.TweenScaleXY(new UAnimation.TweenVector2.Properties
        {
            delay = 6,
            duration = 2,
            direction = UAnimation.Direction.Alternate,
            onCompleteMode = UAnimation.OnCompleteMode.Loop,
            keyframes = new UAnimation.TweenVector2.Keyframe[]
            {
                new UAnimation.TweenVector2.Keyframe
                {
                    key = 100,
                    value = new Vector2(1.5f,1.5f),
                }
            }
        });

    }
}
