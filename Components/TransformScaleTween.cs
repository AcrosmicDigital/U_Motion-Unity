using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using U.Motion;
using System.Linq;

public class TransformScaleTween : MonoBehaviour
{
    public Transform t;
    [Space(20)]
    public bool tweenPosition = false;
    public bool positionX = false;
    public bool positionY = false;
    public bool positionZ = false;
    public Utween.KeyValueVector3[] positionKeyValuePairsABC;
    public Utween.KeyValueVector2[] positionKeyValuePairsAB;
    public Utween.KeyValueFloat[] positionKeyValuePairsA;
    public TimeAnimationParams positionAnimationParams;
    public Utween.KeysCurveMode positionKeysCurveMode;
    [Space(20)]
    public bool tweenRotation = false;
    public bool rotationX = false;
    public bool rotationY = false;
    public bool rotationZ = false;
    public Utween.KeyValueVector3[] rotationKeyValuePairsABC;
    public Utween.KeyValueVector2[] rotationKeyValuePairsAB;
    public Utween.KeyValueFloat[] rotationKeyValuePairsA;
    public TimeAnimationParams rotationAnimationParams;
    public Utween.KeysCurveMode rotationKeysCurveMode;
    [Space(20)]
    public bool tweenScale = false;
    public bool scaleX = false;
    public bool scaleY = false;
    public bool scaleZ = false;
    public Utween.KeyValueVector3[] keyValuePairsABC;
    public Utween.KeyValueVector2[] keyValuePairsAB;
    public Utween.KeyValueFloat[] keyValuePairsA;
    public TimeAnimationParams animationParams;
    public Utween.KeysCurveMode keysCurveMode;


    void Start()
    {
        if (t == null) t = transform;
        


        if (tweenPosition)
        {
            if (positionX && !positionY && !positionZ)
            {
                Utween.AnimateFloat(
                    gameObject,
                    (x) => t.position = new Vector3(x, t.position.y, t.position.z),
                    positionKeyValuePairsA.ToDictionary(k => k.key, v => v.value),
                    positionAnimationParams,
                    positionKeysCurveMode
                );
            }
            else if (!positionX && positionY && !positionZ)
            {
                Utween.AnimateFloat(
                    gameObject,
                    (y) => t.position = new Vector3(t.position.x, y, t.position.z),
                    positionKeyValuePairsA.ToDictionary(k => k.key, v => v.value),
                    positionAnimationParams,
                    positionKeysCurveMode
                );
            }
            else if (!positionX && !positionY && positionZ)
            {
                Utween.AnimateFloat(
                    gameObject,
                    (z) => t.position = new Vector3(t.position.x, t.position.y, z),
                    positionKeyValuePairsA.ToDictionary(k => k.key, v => v.value),
                    positionAnimationParams,
                    positionKeysCurveMode
                );
            }

            else if (positionX && positionY && !positionZ)
            {
                Utween.AnimateVector2(
                    gameObject,
                    (x, y) => t.position = new Vector3(x, y, t.position.z),
                    positionKeyValuePairsAB.ToDictionary(k => k.key, v => v.value),
                    positionAnimationParams,
                    positionKeysCurveMode
                );
            }
            else if (positionX && !positionY && positionZ)
            {
                Utween.AnimateVector2(
                    gameObject,
                    (x, z) => t.position = new Vector3(x, t.position.y, z),
                    positionKeyValuePairsAB.ToDictionary(k => k.key, v => v.value),
                    positionAnimationParams,
                    positionKeysCurveMode
                );
            }
            else if (!positionX && positionY && positionZ)
            {
                Utween.AnimateVector2(
                    gameObject,
                    (y, z) => t.position = new Vector3(t.position.x, y, z),
                    positionKeyValuePairsAB.ToDictionary(k => k.key, v => v.value),
                    positionAnimationParams,
                    positionKeysCurveMode
                );
            }

            else if (positionX && positionY && positionZ)
            {
                Utween.AnimateVector3(
                    gameObject,
                    (x, y, z) => t.position = new Vector3(x, y, z),
                    positionKeyValuePairsABC.ToDictionary(k => k.key, v => v.value),
                    positionAnimationParams,
                    positionKeysCurveMode
                );
            }
        }




        if (tweenRotation)
        {
            if (rotationX && !rotationY && !rotationZ)
            {
                Utween.AnimateFloat(
                    gameObject,
                    (x) => t.rotation = Quaternion.Euler(x, t.rotation.eulerAngles.y, t.rotation.eulerAngles.z),
                    rotationKeyValuePairsA.ToDictionary(k => k.key, v => v.value),
                    rotationAnimationParams,
                    rotationKeysCurveMode
                );
            }
            else if (!rotationX && rotationY && !rotationZ)
            {
                Utween.AnimateFloat(
                    gameObject,
                    (y) => t.rotation = Quaternion.Euler(t.rotation.eulerAngles.x, y, t.rotation.eulerAngles.z),
                    rotationKeyValuePairsA.ToDictionary(k => k.key, v => v.value),
                    rotationAnimationParams,
                    rotationKeysCurveMode
                );
            }
            else if (!rotationX && !rotationY && rotationZ)
            {
                Utween.AnimateFloat(
                    gameObject,
                    (z) => t.rotation = Quaternion.Euler(t.rotation.eulerAngles.x, t.rotation.eulerAngles.y, z),
                    rotationKeyValuePairsA.ToDictionary(k => k.key, v => v.value),
                    rotationAnimationParams,
                    rotationKeysCurveMode
                );
            }

            else if (rotationX && rotationY && !rotationZ)
            {
                Utween.AnimateVector2(
                    gameObject,
                    (x, y) => Quaternion.Euler(t.rotation.eulerAngles.x, y, t.rotation.eulerAngles.z),
                    rotationKeyValuePairsAB.ToDictionary(k => k.key, v => v.value),
                    rotationAnimationParams,
                    rotationKeysCurveMode
                );
            }
            else if (rotationX && !rotationY && rotationZ)
            {
                Utween.AnimateVector2(
                    gameObject,
                    (x, z) => t.rotation = Quaternion.Euler(x, t.rotation.eulerAngles.y, z),
                    rotationKeyValuePairsAB.ToDictionary(k => k.key, v => v.value),
                    rotationAnimationParams,
                    rotationKeysCurveMode
                );
            }
            else if (!rotationX && rotationY && rotationZ)
            {
                Utween.AnimateVector2(
                    gameObject,
                    (y, z) => t.rotation = Quaternion.Euler(t.rotation.eulerAngles.x, y, z),
                    rotationKeyValuePairsAB.ToDictionary(k => k.key, v => v.value),
                    rotationAnimationParams,
                    rotationKeysCurveMode
                );
            }

            else if (rotationX && rotationY && rotationZ)
            {
                Utween.AnimateVector3(
                    gameObject,
                    (x, y, z) => t.rotation = Quaternion.Euler(x,y,z),
                    rotationKeyValuePairsABC.ToDictionary(k => k.key, v => v.value),
                    rotationAnimationParams,
                    rotationKeysCurveMode
                );;
            }
        }
         



        if (tweenScale)
        {
            if (tweenScale && scaleX && !scaleY && !scaleZ)
            {
                Utween.AnimateFloat(
                    gameObject,
                    (x) => t.localScale = new Vector3(x, t.localScale.y, t.localScale.z),
                    keyValuePairsA.ToDictionary(k => k.key, v => v.value),
                    animationParams,
                    keysCurveMode
                );
            }
            else if (tweenScale && !scaleX && scaleY && !scaleZ)
            {
                Utween.AnimateFloat(
                    gameObject,
                    (y) => t.localScale = new Vector3(t.localScale.x, y, t.localScale.z),
                    keyValuePairsA.ToDictionary(k => k.key, v => v.value),
                    animationParams,
                    keysCurveMode
                );
            }
            else if (tweenScale && !scaleX && !scaleY && scaleZ)
            {
                Utween.AnimateFloat(
                    gameObject,
                    (z) => t.localScale = new Vector3(t.localScale.x, t.localScale.y, z),
                    keyValuePairsA.ToDictionary(k => k.key, v => v.value),
                    animationParams,
                    keysCurveMode
                );
            }

            else if (tweenScale && scaleX && scaleY && !scaleZ)
            {
                Utween.AnimateVector2(
                    gameObject,
                    (x, y) => t.localScale = new Vector3(x, y, t.localScale.z),
                    keyValuePairsAB.ToDictionary(k => k.key, v => v.value),
                    animationParams,
                    keysCurveMode
                );
            }
            else if (tweenScale && scaleX && !scaleY && scaleZ)
            {
                Utween.AnimateVector2(
                    gameObject,
                    (x, z) => t.localScale = new Vector3(x, t.localScale.y, z),
                    keyValuePairsAB.ToDictionary(k => k.key, v => v.value),
                    animationParams,
                    keysCurveMode
                );
            }
            else if (tweenScale && !scaleX && scaleY && scaleZ)
            {
                Utween.AnimateVector2(
                    gameObject,
                    (y, z) => t.localScale = new Vector3(t.localScale.x, y, z),
                    keyValuePairsAB.ToDictionary(k => k.key, v => v.value),
                    animationParams,
                    keysCurveMode
                );
            }

            else if (tweenScale && scaleX && scaleY && scaleZ)
            {
                Utween.AnimateVector3(
                    gameObject,
                    (x, y, z) => t.localScale = new Vector3(x, y, z),
                    keyValuePairsABC.ToDictionary(k => k.key, v => v.value),
                    animationParams,
                    keysCurveMode
                );
            }
        }



    }

}
