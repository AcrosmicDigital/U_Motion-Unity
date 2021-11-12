using UnityEngine;
using static U.Motion.Uanimation;

public class TweenValueScript : MonoBehaviour
{

    Rigidbody2D rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();



        TweenFloat.AddComponent(gameObject, new TweenFloat.Properties
        {
            duration = 5,
            direction = Direction.Alternate,
            iterations = 4,
            animate = (p) => 
            {
                rb.gravityScale = p;  
            },
            keyframes = new TweenFloat.Keyframe[]
            {
                new TweenFloat.Keyframe
                {
                    key = 0,
                    value = -1f
                },
                new TweenFloat.Keyframe
                {
                    key = 100,
                    value = 1
                }
            },
            onCompleteAction = () => Debug.Log("Completed"),
        });



    }

}
