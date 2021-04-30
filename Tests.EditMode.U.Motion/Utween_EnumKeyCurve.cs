using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using U.Motion;
using UnityEngine;

public class Utween_EnumKeyCurve
{

    // If you have an enum or any other base Type that you want to animate
    // (Datatypes like Vector3 are composed data types, they contain 3 foats
    // Only crate KeysCurve for basic data types or any data type that can be converted to a float value

    // This is the data type
    enum Mode
    {
        First,
        Second,
        Thirth,
    }

    // Now you need to inherit KeysCurve<DataType> and create the constructor, and two methods
    // use *DataType*KeysCurve to name the new class

    class ModeKeysCurve : KeyFramesCurve<Mode>
    {
        // The constructor that accepts a Dictionary of <int, datatype>
        public ModeKeysCurve(Dictionary<int, Mode> keys, Utween.KeysCurveMode curveMode) : base(keys, curveMode) { }


        // Specify how to cast from the DataTye to a float
        protected override float GetFloatFromTValue(Mode value)
        {
            
            if (value == Mode.First)
                return 1f;
            else if (value == Mode.Second)
                return 2f;
            else
                return 3f;
        }

        // Specify how to cast from the float to the data Type
        protected override Mode GetTValueFromFloat(float value)
        {
            
            if (value <= 1)
                return Mode.First;
            else if (value <= 2)
                return Mode.Second;
            else
                return Mode.Thirth;
        }
    }



    // If you use Slope curves with an enum you will pas from all the intermediate states between first ans last state,
    // If you want to avoid this behaviour use the Step mode
    [Test]
    public void EnumKeyCurve_CurveModeSlope()
    {

        ModeKeysCurve enumKeysCurve;
        Dictionary<int, Mode> keyFrames;




        keyFrames = new Dictionary<int, Mode>
        {
            {0, Mode.First },
            {100, Mode.Thirth },
        };

        Debug.Log("--> Prueba 1:");
        enumKeysCurve = new ModeKeysCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + enumKeysCurve.Evaluate(0));
        Assert.AreEqual(Mode.First, enumKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + enumKeysCurve.Evaluate(.25f));
        Assert.AreEqual(Mode.Second, enumKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + enumKeysCurve.Evaluate(.5f));
        Assert.AreEqual(Mode.Second, enumKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + enumKeysCurve.Evaluate(.75f));
        Assert.AreEqual(Mode.Thirth, enumKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + enumKeysCurve.Evaluate(1));
        Assert.AreEqual(Mode.Thirth, enumKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + enumKeysCurve.Evaluate(-1f));
        Assert.AreEqual(Mode.First, enumKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + enumKeysCurve.Evaluate(2));
        Assert.AreEqual(Mode.Thirth, enumKeysCurve.Evaluate(2));





        keyFrames = new Dictionary<int, Mode>
        {
            {0, Mode.First },
            {20, Mode.First },
            {40, Mode.First },
            {60, Mode.First },
            {80, Mode.First },
            {100, Mode.First },
        };

        Debug.Log("--> Prueba 3:");
        enumKeysCurve = new ModeKeysCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + enumKeysCurve.Evaluate(0));
        Assert.AreEqual(Mode.First, enumKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + enumKeysCurve.Evaluate(.25f));
        Assert.AreEqual(Mode.First, enumKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + enumKeysCurve.Evaluate(.5f));
        Assert.AreEqual(Mode.First, enumKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + enumKeysCurve.Evaluate(.75f));
        Assert.AreEqual(Mode.First, enumKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + enumKeysCurve.Evaluate(1));
        Assert.AreEqual(Mode.First, enumKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + enumKeysCurve.Evaluate(-1f));
        Assert.AreEqual(Mode.First, enumKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + enumKeysCurve.Evaluate(2));
        Assert.AreEqual(Mode.First, enumKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, Mode>
        {
            {25, Mode.First },
        };

        Debug.Log("--> Prueba 1:");
        enumKeysCurve = new ModeKeysCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + enumKeysCurve.Evaluate(0));
        Assert.AreEqual(Mode.First, enumKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + enumKeysCurve.Evaluate(.25f));
        Assert.AreEqual(Mode.First, enumKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + enumKeysCurve.Evaluate(.5f));
        Assert.AreEqual(Mode.First, enumKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + enumKeysCurve.Evaluate(.75f));
        Assert.AreEqual(Mode.First, enumKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + enumKeysCurve.Evaluate(1));
        Assert.AreEqual(Mode.First, enumKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + enumKeysCurve.Evaluate(-1f));
        Assert.AreEqual(Mode.First, enumKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + enumKeysCurve.Evaluate(2));
        Assert.AreEqual(Mode.First, enumKeysCurve.Evaluate(2));


    }




    [Test]
    public void EnumKeyCurve_CurveModeStep()
    {

        ModeKeysCurve boolKeysCurve;
        Dictionary<int, Mode> keyFrames;




        keyFrames = new Dictionary<int, Mode>
        {
            {0, Mode.First },
            {100, Mode.Thirth },
        };

        Debug.Log("--> Prueba 1:");
        boolKeysCurve = new ModeKeysCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + boolKeysCurve.Evaluate(0));
        Assert.AreEqual(Mode.First, boolKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + boolKeysCurve.Evaluate(.25f));
        Assert.AreEqual(Mode.First, boolKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + boolKeysCurve.Evaluate(.5f));
        Assert.AreEqual(Mode.First, boolKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + boolKeysCurve.Evaluate(.75f));
        Assert.AreEqual(Mode.First, boolKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + boolKeysCurve.Evaluate(1));
        Assert.AreEqual(Mode.Thirth, boolKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + boolKeysCurve.Evaluate(-1f));
        Assert.AreEqual(Mode.First, boolKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + boolKeysCurve.Evaluate(2));
        Assert.AreEqual(Mode.Thirth, boolKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, Mode>
        {
            {0, Mode.First },
            {20, Mode.First },
            {40, Mode.First },
            {60, Mode.First },
            {80, Mode.First },
            {100, Mode.First },
        };

        Debug.Log("--> Prueba 3:");
        boolKeysCurve = new ModeKeysCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + boolKeysCurve.Evaluate(0));
        Assert.AreEqual(Mode.First, boolKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + boolKeysCurve.Evaluate(.25f));
        Assert.AreEqual(Mode.First, boolKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + boolKeysCurve.Evaluate(.5f));
        Assert.AreEqual(Mode.First, boolKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + boolKeysCurve.Evaluate(.75f));
        Assert.AreEqual(Mode.First, boolKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + boolKeysCurve.Evaluate(1));
        Assert.AreEqual(Mode.First, boolKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + boolKeysCurve.Evaluate(-1f));
        Assert.AreEqual(Mode.First, boolKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + boolKeysCurve.Evaluate(2));
        Assert.AreEqual(Mode.First, boolKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, Mode>
        {
            {25, Mode.First },
        };

        Debug.Log("--> Prueba 1:");
        boolKeysCurve = new ModeKeysCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + boolKeysCurve.Evaluate(0));
        Assert.AreEqual(Mode.First, boolKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + boolKeysCurve.Evaluate(.25f));
        Assert.AreEqual(Mode.First, boolKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + boolKeysCurve.Evaluate(.5f));
        Assert.AreEqual(Mode.First, boolKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + boolKeysCurve.Evaluate(.75f));
        Assert.AreEqual(Mode.First, boolKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + boolKeysCurve.Evaluate(1));
        Assert.AreEqual(Mode.First, boolKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + boolKeysCurve.Evaluate(-1f));
        Assert.AreEqual(Mode.First, boolKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + boolKeysCurve.Evaluate(2));
        Assert.AreEqual(Mode.First, boolKeysCurve.Evaluate(2));


    }




    [Test]
    public void EnumKeyCurve_WhenInvalidKeysPassed()
    {

        ModeKeysCurve boolKeysCurve = null;
        Dictionary<int, Mode> keyFrames;



        keyFrames = new Dictionary<int, Mode>
        {
            {-2, Mode.First },
            {100, Mode.Second },
        };

        Debug.Log("--> Prueba 1:");
        Assert.Throws<ArgumentOutOfRangeException>(() => new ModeKeysCurve(keyFrames, Utween.KeysCurveMode.Step));




        keyFrames = new Dictionary<int, Mode>
        {
            {0, Mode.First },
            {200, Mode.First },
        };

        Debug.Log("--> Prueba 2:");
        Assert.Throws<ArgumentOutOfRangeException>(() => new ModeKeysCurve(keyFrames, Utween.KeysCurveMode.Step));





        Assert.Throws<ArgumentException>(() => keyFrames = new Dictionary<int, Mode>
        {
            {40, Mode.First },
            {40, Mode.First },
        });






        keyFrames = new Dictionary<int, Mode>
        {
            {-10, Mode.First },
            {300, Mode.First },
        };

        Debug.Log("--> Prueba 4:");
        Assert.Throws<ArgumentOutOfRangeException>(() => new ModeKeysCurve(keyFrames, Utween.KeysCurveMode.Step));





        // When a Key curve badly created is evaluated, it will throw an null reference exception

        try
        {
            keyFrames = new Dictionary<int, Mode>
            {
                {-10, Mode.First },
                {300, Mode.First },
            };

            boolKeysCurve = new ModeKeysCurve(keyFrames, Utween.KeysCurveMode.Step);
        }
        catch (Exception)
        {
        }

        Debug.Log("--> Prueba 5:");
        Assert.Throws<NullReferenceException>(() => boolKeysCurve.Evaluate(.25f));

    }



}
