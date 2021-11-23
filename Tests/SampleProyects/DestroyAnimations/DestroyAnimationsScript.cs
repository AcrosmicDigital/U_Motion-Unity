using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using U.Motion;

public class DestroyAnimationsScript : MonoBehaviour
{

    IAnimatorCore scaleAnim;
    IAnimatorCore positionAnim;

    // Start is called before the first frame update
    void Start()
    {

        // Add scale and position animatios

        positionAnim = gameObject
                .transform.TweenPositionXY(new UAnimation.TweenVector2.Properties
                {
                    duration = 2,
                    direction = UAnimation.Direction.Alternate,
                    onCompleteMode = UAnimation.OnCompleteMode.Loop,
                    keyframes = new UAnimation.TweenVector2.Keyframe[]
                    {
                        new UAnimation.TweenVector2.Keyframe
                        {
                            key = 0,
                            value = new Vector2(0f, 0f),
                        },
                        new UAnimation.TweenVector2.Keyframe
                        {
                            key = 100,
                            value = new Vector2(1f, 1f),
                        },
                    },
                });

        scaleAnim = gameObject
            .transform.TweenScaleXY(new UAnimation.TweenVector2.Properties
            {
                duration = 2,
                direction = UAnimation.Direction.Alternate,
                onCompleteMode = UAnimation.OnCompleteMode.Loop,
                keyframes = new UAnimation.TweenVector2.Keyframe[]
                {
                        new UAnimation.TweenVector2.Keyframe
                        {
                            key = 0,
                            value = new Vector2(1.1f,1.1f)
                        },
                        new UAnimation.TweenVector2.Keyframe
                        {
                            key = 100,
                            value = new Vector2(.7f, .7f),
                        },
                },
            });


        // Start coroutines
        StartCoroutine(RemoveAndAddNews());
        StartCoroutine(RemoveAll());

    }


    private IEnumerator RemoveAndAddNews()
    {
        yield return new WaitForSeconds(10);

        // Destroy individual Animation
        positionAnim.DestroyAnimation();
        scaleAnim.DestroyAnimation();

        // New Animation
        positionAnim = gameObject
                .transform.TweenPositionXY(new UAnimation.TweenVector2.Properties
                {
                    duration = 2,
                    direction = UAnimation.Direction.Alternate,
                    onCompleteMode = UAnimation.OnCompleteMode.Loop,
                    keyframes = new UAnimation.TweenVector2.Keyframe[]
                    {
                        new UAnimation.TweenVector2.Keyframe
                        {
                            key = 0,
                            value = new Vector2(0f, 0f),
                        },
                        new UAnimation.TweenVector2.Keyframe
                        {
                            key = 100,
                            value = new Vector2(1f, 1f),
                        },
                    },
                });

        scaleAnim = gameObject
            .transform.TweenScaleXY(new UAnimation.TweenVector2.Properties
            {
                duration = 2,
                direction = UAnimation.Direction.Alternate,
                onCompleteMode = UAnimation.OnCompleteMode.Loop,
                keyframes = new UAnimation.TweenVector2.Keyframe[]
                {
                        new UAnimation.TweenVector2.Keyframe
                        {
                            key = 0,
                            value = new Vector2(.7f, .7f),
                        },
                        new UAnimation.TweenVector2.Keyframe
                        {
                            key = 100,
                            value = new Vector2(1.1f,1.1f)
                        },
                },
            });

    }


    private IEnumerator RemoveAll()
    {
        yield return new WaitForSeconds(20);

        // Destroy all animations in Gameobject
        gameObject.DestroyAnimations();


        // New Animation
        positionAnim = gameObject
                .transform.TweenPositionXY(new UAnimation.TweenVector2.Properties
                {
                    duration = 2,
                    direction = UAnimation.Direction.Alternate,
                    onCompleteMode = UAnimation.OnCompleteMode.Loop,
                    keyframes = new UAnimation.TweenVector2.Keyframe[]
                    {
                        new UAnimation.TweenVector2.Keyframe
                        {
                            key = 0,
                            value = new Vector2(-1f, -1f),
                        },
                        new UAnimation.TweenVector2.Keyframe
                        {
                            key = 100,
                            value = new Vector2(1f, 1f),
                        },
                    },
                });

        scaleAnim = gameObject
            .transform.TweenScaleXY(new UAnimation.TweenVector2.Properties
            {
                duration = 2,
                direction = UAnimation.Direction.Alternate,
                onCompleteMode = UAnimation.OnCompleteMode.Loop,
                keyframes = new UAnimation.TweenVector2.Keyframe[]
                {
                        new UAnimation.TweenVector2.Keyframe
                        {
                            key = 0,
                            value = new Vector2(.5f, .5f),
                        },
                        new UAnimation.TweenVector2.Keyframe
                        {
                            key = 100,
                            value = new Vector2(1f,1f)
                        },
                },
            });

    }


}
