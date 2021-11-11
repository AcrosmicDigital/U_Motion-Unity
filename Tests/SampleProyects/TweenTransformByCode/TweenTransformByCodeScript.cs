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
        transform.TweenPositionY(new Uanimators.TweenFloat.Properties
        {
            delay = 6,
            duration = 2,
            direction = Utween.Direction.Alternate,
            onCompleteMode = Utween.OnCompleteMode.Loop,
            keyframes = new Uanimators.TweenFloat.Keyframe[]
            {
                new Uanimators.TweenFloat.Keyframe
                {
                    key = 100,
                    value = 3,
                }
            }
        });

        // Tween transform By code
        transform.TweenScaleXY(new Uanimators.TweenVector2.Properties
        {
            delay = 6,
            duration = 2,
            direction = Utween.Direction.Alternate,
            onCompleteMode = Utween.OnCompleteMode.Loop,
            keyframes = new Uanimators.TweenVector2.Keyframe[]
            {
                new Uanimators.TweenVector2.Keyframe
                {
                    key = 100,
                    value = new Vector2(1.5f,1.5f),
                }
            }
        });

    }
}
