using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using U.Motion;
using System.Linq;

public class TweenTransform : MonoBehaviour
{
    [Space(10)]
    public Transform Transform;

    [Header("Position")]
    public bool tweenPosition = false;
    public bool positionX = false;
    public bool positionY = false;
    public bool positionZ = false;
    public Utween.KeyValueVector3[] positionKeyValuePairsABC;
    public Utween.KeyValueVector2[] positionKeyValuePairsAB;
    public Utween.KeyValueFloat[] positionKeyValuePairsA;
    public TimeAnimationParams positionAnimationParams;
    public Utween.KeysCurveMode positionKeysCurveMode;

    [Header("Rotation")]
    public bool tweenRotation = false;
    public bool rotationX = false;
    public bool rotationY = false;
    public bool rotationZ = false;
    public Utween.KeyValueVector3[] rotationKeyValuePairsABC;
    public Utween.KeyValueVector2[] rotationKeyValuePairsAB;
    public Utween.KeyValueFloat[] rotationKeyValuePairsA;
    public TimeAnimationParams rotationAnimationParams;
    public Utween.KeysCurveMode rotationKeysCurveMode;

    [Header("Scale")]
    public bool tweenScale = false;
    public bool scaleX = false;
    public bool scaleY = false;
    public bool scaleZ = false;
    public Utween.KeyValueVector3[] scaleKeyValuePairsABC;
    public Utween.KeyValueVector2[] scaleKeyValuePairsAB;
    public Utween.KeyValueFloat[] scaleKeyValuePairsA;
    public TimeAnimationParams scaleAnimationParams;
    public Utween.KeysCurveMode scaleKeysCurveMode;


    void Start()
    {
        if (Transform == null) Transform = transform;

        if (transform == null) return;
        


        if (tweenPosition)
        {
            if (positionX && !positionY && !positionZ)
            {
                Utween.AnimateFloat(
                    Transform.gameObject,
                    (x) => Transform.position = new Vector3(x, Transform.position.y, Transform.position.z),
                    positionKeyValuePairsA.ToDictionary(k => k.key, v => v.value),
                    positionAnimationParams,
                    positionKeysCurveMode
                );
            }
            else if (!positionX && positionY && !positionZ)
            {
                Utween.AnimateFloat(
                    Transform.gameObject,
                    (y) => Transform.position = new Vector3(Transform.position.x, y, Transform.position.z),
                    positionKeyValuePairsA.ToDictionary(k => k.key, v => v.value),
                    positionAnimationParams,
                    positionKeysCurveMode
                );
            }
            else if (!positionX && !positionY && positionZ)
            {
                Utween.AnimateFloat(
                    Transform.gameObject,
                    (z) => Transform.position = new Vector3(Transform.position.x, Transform.position.y, z),
                    positionKeyValuePairsA.ToDictionary(k => k.key, v => v.value),
                    positionAnimationParams,
                    positionKeysCurveMode
                );
            }

            else if (positionX && positionY && !positionZ)
            {
                Utween.AnimateVector2(
                    Transform.gameObject,
                    (x, y) => Transform.position = new Vector3(x, y, Transform.position.z),
                    positionKeyValuePairsAB.ToDictionary(k => k.key, v => v.value),
                    positionAnimationParams,
                    positionKeysCurveMode
                );
            }
            else if (positionX && !positionY && positionZ)
            {
                Utween.AnimateVector2(
                    Transform.gameObject,
                    (x, z) => Transform.position = new Vector3(x, Transform.position.y, z),
                    positionKeyValuePairsAB.ToDictionary(k => k.key, v => v.value),
                    positionAnimationParams,
                    positionKeysCurveMode
                );
            }
            else if (!positionX && positionY && positionZ)
            {
                Utween.AnimateVector2(
                    Transform.gameObject,
                    (y, z) => Transform.position = new Vector3(Transform.position.x, y, z),
                    positionKeyValuePairsAB.ToDictionary(k => k.key, v => v.value),
                    positionAnimationParams,
                    positionKeysCurveMode
                );
            }

            else if (positionX && positionY && positionZ)
            {
                Utween.AnimateVector3(
                    Transform.gameObject,
                    (x, y, z) => Transform.position = new Vector3(x, y, z),
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
                    Transform.gameObject,
                    (x) => Transform.rotation = Quaternion.Euler(x, Transform.rotation.eulerAngles.y, Transform.rotation.eulerAngles.z),
                    rotationKeyValuePairsA.ToDictionary(k => k.key, v => v.value),
                    rotationAnimationParams,
                    rotationKeysCurveMode
                );
            }
            else if (!rotationX && rotationY && !rotationZ)
            {
                Utween.AnimateFloat(
                    Transform.gameObject,
                    (y) => Transform.rotation = Quaternion.Euler(Transform.rotation.eulerAngles.x, y, Transform.rotation.eulerAngles.z),
                    rotationKeyValuePairsA.ToDictionary(k => k.key, v => v.value),
                    rotationAnimationParams,
                    rotationKeysCurveMode
                );
            }
            else if (!rotationX && !rotationY && rotationZ)
            {
                Utween.AnimateFloat(
                    Transform.gameObject,
                    (z) => Transform.rotation = Quaternion.Euler(Transform.rotation.eulerAngles.x, Transform.rotation.eulerAngles.y, z),
                    rotationKeyValuePairsA.ToDictionary(k => k.key, v => v.value),
                    rotationAnimationParams,
                    rotationKeysCurveMode
                );
            }

            else if (rotationX && rotationY && !rotationZ)
            {
                Utween.AnimateVector2(
                    Transform.gameObject,
                    (x, y) => Quaternion.Euler(Transform.rotation.eulerAngles.x, y, Transform.rotation.eulerAngles.z),
                    rotationKeyValuePairsAB.ToDictionary(k => k.key, v => v.value),
                    rotationAnimationParams,
                    rotationKeysCurveMode
                );
            }
            else if (rotationX && !rotationY && rotationZ)
            {
                Utween.AnimateVector2(
                    Transform.gameObject,
                    (x, z) => Transform.rotation = Quaternion.Euler(x, Transform.rotation.eulerAngles.y, z),
                    rotationKeyValuePairsAB.ToDictionary(k => k.key, v => v.value),
                    rotationAnimationParams,
                    rotationKeysCurveMode
                );
            }
            else if (!rotationX && rotationY && rotationZ)
            {
                Utween.AnimateVector2(
                    Transform.gameObject,
                    (y, z) => Transform.rotation = Quaternion.Euler(Transform.rotation.eulerAngles.x, y, z),
                    rotationKeyValuePairsAB.ToDictionary(k => k.key, v => v.value),
                    rotationAnimationParams,
                    rotationKeysCurveMode
                );
            }

            else if (rotationX && rotationY && rotationZ)
            {
                Utween.AnimateVector3(
                    Transform.gameObject,
                    (x, y, z) => Transform.rotation = Quaternion.Euler(x,y,z),
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
                    Transform.gameObject,
                    (x) => Transform.localScale = new Vector3(x, Transform.localScale.y, Transform.localScale.z),
                    scaleKeyValuePairsA.ToDictionary(k => k.key, v => v.value),
                    scaleAnimationParams,
                    scaleKeysCurveMode
                );
            }
            else if (tweenScale && !scaleX && scaleY && !scaleZ)
            {
                Utween.AnimateFloat(
                    Transform.gameObject,
                    (y) => Transform.localScale = new Vector3(Transform.localScale.x, y, Transform.localScale.z),
                    scaleKeyValuePairsA.ToDictionary(k => k.key, v => v.value),
                    scaleAnimationParams,
                    scaleKeysCurveMode
                );
            }
            else if (tweenScale && !scaleX && !scaleY && scaleZ)
            {
                Utween.AnimateFloat(
                    Transform.gameObject,
                    (z) => Transform.localScale = new Vector3(Transform.localScale.x, Transform.localScale.y, z),
                    scaleKeyValuePairsA.ToDictionary(k => k.key, v => v.value),
                    scaleAnimationParams,
                    scaleKeysCurveMode
                );
            }

            else if (tweenScale && scaleX && scaleY && !scaleZ)
            {
                Utween.AnimateVector2(
                    Transform.gameObject,
                    (x, y) => Transform.localScale = new Vector3(x, y, Transform.localScale.z),
                    scaleKeyValuePairsAB.ToDictionary(k => k.key, v => v.value),
                    scaleAnimationParams,
                    scaleKeysCurveMode
                );
            }
            else if (tweenScale && scaleX && !scaleY && scaleZ)
            {
                Utween.AnimateVector2(
                    Transform.gameObject,
                    (x, z) => Transform.localScale = new Vector3(x, Transform.localScale.y, z),
                    scaleKeyValuePairsAB.ToDictionary(k => k.key, v => v.value),
                    scaleAnimationParams,
                    scaleKeysCurveMode
                );
            }
            else if (tweenScale && !scaleX && scaleY && scaleZ)
            {
                Utween.AnimateVector2(
                    Transform.gameObject,
                    (y, z) => Transform.localScale = new Vector3(Transform.localScale.x, y, z),
                    scaleKeyValuePairsAB.ToDictionary(k => k.key, v => v.value),
                    scaleAnimationParams,
                    scaleKeysCurveMode
                );
            }

            else if (tweenScale && scaleX && scaleY && scaleZ)
            {
                Utween.AnimateVector3(
                    Transform.gameObject,
                    (x, y, z) => Transform.localScale = new Vector3(x, y, z),
                    scaleKeyValuePairsABC.ToDictionary(k => k.key, v => v.value),
                    scaleAnimationParams,
                    scaleKeysCurveMode
                );
            }
        }



    }

}
