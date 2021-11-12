using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static U.Motion.Uanimators;

public class TweenValueScript : MonoBehaviour
{

    Rigidbody2D rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        TweenFloat.AddComponent(gameObject, new TweenFloat.Properties
        {
            animate = (p) => 
            {
                
            },
        });
    }

}
