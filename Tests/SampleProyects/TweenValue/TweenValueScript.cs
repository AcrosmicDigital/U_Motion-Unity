using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenValueScript : MonoBehaviour
{

    Rigidbody2D rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

}
