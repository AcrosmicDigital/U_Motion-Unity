using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace U.Motion
{

    // Probada

    public abstract class KeyFramesCurve<TValue>
    {

        private readonly AnimationCurve animationCurve; // The animation curve reference


        // Abstract functions to get set TValue from float
        protected abstract float GetFloatFromTValue(TValue value); 
        protected abstract TValue GetTValueFromFloat(float value);

        // Evaluate the curve at percentage x
        public TValue Evaluate(float percentage) => GetTValueFromFloat(animationCurve.Evaluate(percentage));


        // Constructor
        public KeyFramesCurve(Dictionary<int, TValue> keys, UAnimation.KeysCurveMode curveMode)
        {

            // Validate the values of the keys
            foreach(var key in keys)
            {
                if (key.Key < 0 || key.Key > 100)
                    throw new ArgumentOutOfRangeException("Key.percentage must be >=0 and <=100");
            }

            // Transform Tvalues and the percentage to float
            var keysArray = keys.Select(k => new KeyValuePair<float, float>(k.Key / 100f, GetFloatFromTValue(k.Value))).ToArray();


            // Craeate the curve
            if (curveMode == UAnimation.KeysCurveMode.Step)
                animationCurve = CreateStepCurve(keysArray);
            else
                animationCurve = CreateSlopeCurve(keysArray);

        }

        

        // Create a linear curve 
        private AnimationCurve CreateSlopeCurve(KeyValuePair<float, float>[] keysArray)
        {

            //Debug.Log("Lenght: " + keysArray.Length);
            var frames = new Keyframe[keysArray.Length];


            for (int i = 0; i < keysArray.Length; i++)
            {

                //Debug.Log("Index: " + i);

                if (keysArray.Length == 1)
                {
                    frames[i] = new Keyframe(
                    time: keysArray[i].Key,
                    value: keysArray[i].Value,
                    inTangent: 0,
                    outTangent: 0
                    );
                }
                else if (i == 0)
                {
                    frames[i] = new Keyframe(
                    time: keysArray[i].Key,
                    value: keysArray[i].Value,
                    inTangent: 0,
                    outTangent: (keysArray[i + 1].Value - keysArray[i].Value) / (keysArray[i + 1].Key - keysArray[i].Key)
                    );
                }
                else if (i == (keysArray.Length - 1))
                {
                    frames[i] = new Keyframe(
                    time: keysArray[i].Key,
                    value: keysArray[i].Value,
                    inTangent: (keysArray[i].Value - keysArray[i - 1].Value) / (keysArray[i].Key - keysArray[i - 1].Key),
                    outTangent: 0
                    );
                }
                else
                {
                    frames[i] = new Keyframe(
                    time: keysArray[i].Key,
                    value: keysArray[i].Value,
                    inTangent: (keysArray[i].Value - keysArray[i - 1].Value) / (keysArray[i].Key - keysArray[i - 1].Key),
                    outTangent: (keysArray[i + 1].Value - keysArray[i].Value) / (keysArray[i + 1].Key - keysArray[i].Key)
                    );

                    //Debug.Log("inTangent: (" + keysArray[i].Value + " - " + keysArray[i - 1].Value + ") / (" + keysArray[i].Key + " - " + keysArray[i - 1].Key + ") = (" + (keysArray[i].Value - keysArray[i - 1].Value) + " / " + (keysArray[i].Key - keysArray[i - 1].Key) + ") = (" + (keysArray[i].Value - keysArray[i - 1].Value) / (keysArray[i].Key - keysArray[i - 1].Key) + ")");
                    //Debug.Log("outTangent: (" + keysArray[i + 1].Value + " - " + keysArray[i].Value + ") / (" + keysArray[i + 1].Key + " - " + keysArray[i].Key + ") = (" + (keysArray[i + 1].Value - keysArray[i].Value) + " / " + (keysArray[i + 1].Key - keysArray[i].Key) + ") =  (" + (keysArray[i + 1].Value - keysArray[i].Value) / (keysArray[i + 1].Key - keysArray[i].Key) + ")");
                }

                if (float.IsNaN(frames[i].inTangent))
                    frames[i].inTangent = 0;

                if (float.IsNaN(frames[i].outTangent))
                    frames[i].outTangent = 0;

            }

            return new AnimationCurve(frames);
        }

        private AnimationCurve CreateStepCurve(KeyValuePair<float, float>[] keysArray)
        {
            var frames = keysArray.Select(k => new Keyframe(k.Key, k.Value, float.PositiveInfinity, float.PositiveInfinity)).ToArray();

            return new AnimationCurve(frames);
        }




        // Transform to an AnimationCurve
        public static implicit operator AnimationCurve(KeyFramesCurve<TValue> keyCurve)
        {
            return keyCurve.animationCurve;
        }

    }
}
