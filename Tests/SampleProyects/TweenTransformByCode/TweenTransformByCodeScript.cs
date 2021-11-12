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
        transform.TweenPositionY(new Uanimation.TweenFloat.Properties
        {
            delay = 6,
            duration = 2,
            direction = Uanimation.Direction.Alternate,
            onCompleteMode = Uanimation.OnCompleteMode.Loop,
            keyframes = new Uanimation.TweenFloat.Keyframe[]
            {
                new Uanimation.TweenFloat.Keyframe
                {
                    key = 100,
                    value = 3,
                }
            }
        });

        // Tween transform By code
        transform.TweenScaleXY(new Uanimation.TweenVector2.Properties
        {
            delay = 6,
            duration = 2,
            direction = Uanimation.Direction.Alternate,
            onCompleteMode = Uanimation.OnCompleteMode.Loop,
            keyframes = new Uanimation.TweenVector2.Keyframe[]
            {
                new Uanimation.TweenVector2.Keyframe
                {
                    key = 100,
                    value = new Vector2(1.5f,1.5f),
                }
            }
        });

    }
}
