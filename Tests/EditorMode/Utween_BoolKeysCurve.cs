using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using U.Motion;
using System;

public class Utween_BoolKeysCurve
{


    [Test]
    public void BoolKeysCurve_CurveModeSlope()
    {

        BoolKeyframesCurve boolKeysCurve;
        Dictionary<int, bool> keyFrames;




        keyFrames = new Dictionary<int, bool>
        {
            {0, false },
            {100, true },
        };

        Debug.Log("--> Prueba 1:");
        boolKeysCurve = new BoolKeyframesCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + boolKeysCurve.Evaluate(0));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + boolKeysCurve.Evaluate(.25f));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + boolKeysCurve.Evaluate(.5f));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + boolKeysCurve.Evaluate(.75f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + boolKeysCurve.Evaluate(1));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + boolKeysCurve.Evaluate(-1f));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + boolKeysCurve.Evaluate(2));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, bool>
        {
            {0, false },
            {50, true },
            {100, false },
        };

        Debug.Log("--> Prueba 2:");
        boolKeysCurve = new BoolKeyframesCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + boolKeysCurve.Evaluate(0));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + boolKeysCurve.Evaluate(.25f));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + boolKeysCurve.Evaluate(.5f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + boolKeysCurve.Evaluate(.75f));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + boolKeysCurve.Evaluate(1));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + boolKeysCurve.Evaluate(-1f));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + boolKeysCurve.Evaluate(2));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, bool>
        {
            {0, true },
            {50, false },
            {100, true },
        };

        Debug.Log("--> Prueba 3:");
        boolKeysCurve = new BoolKeyframesCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + boolKeysCurve.Evaluate(0));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + boolKeysCurve.Evaluate(.25f));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + boolKeysCurve.Evaluate(.5f));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + boolKeysCurve.Evaluate(.75f));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + boolKeysCurve.Evaluate(1));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + boolKeysCurve.Evaluate(-1f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + boolKeysCurve.Evaluate(2));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, bool>
        {
            {0, true },
            {20, true },
            {40, true },
            {60, true },
            {80, true },
            {100, true },
        };

        Debug.Log("--> Prueba 3:");
        boolKeysCurve = new BoolKeyframesCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + boolKeysCurve.Evaluate(0));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + boolKeysCurve.Evaluate(.25f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + boolKeysCurve.Evaluate(.5f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + boolKeysCurve.Evaluate(.75f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + boolKeysCurve.Evaluate(1));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + boolKeysCurve.Evaluate(-1f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + boolKeysCurve.Evaluate(2));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, bool>
        {
            {25, true },
        };

        Debug.Log("--> Prueba 1:");
        boolKeysCurve = new BoolKeyframesCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + boolKeysCurve.Evaluate(0));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + boolKeysCurve.Evaluate(.25f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + boolKeysCurve.Evaluate(.5f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + boolKeysCurve.Evaluate(.75f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + boolKeysCurve.Evaluate(1));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + boolKeysCurve.Evaluate(-1f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + boolKeysCurve.Evaluate(2));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(2));


    }




    [Test]
    public void BoolKeysCurve_CurveModeStep()
    {

        BoolKeyframesCurve boolKeysCurve;
        Dictionary<int, bool> keyFrames;




        keyFrames = new Dictionary<int, bool>
        {
            {0, false },
            {100, true },
        };

        Debug.Log("--> Prueba 1:");
        boolKeysCurve = new BoolKeyframesCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + boolKeysCurve.Evaluate(0));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + boolKeysCurve.Evaluate(.25f));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + boolKeysCurve.Evaluate(.5f));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + boolKeysCurve.Evaluate(.75f));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + boolKeysCurve.Evaluate(1));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + boolKeysCurve.Evaluate(-1f));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + boolKeysCurve.Evaluate(2));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, bool>
        {
            {0, false },
            {50, true },
            {100, false },
        };

        Debug.Log("--> Prueba 2:");
        boolKeysCurve = new BoolKeyframesCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + boolKeysCurve.Evaluate(0));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + boolKeysCurve.Evaluate(.25f));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + boolKeysCurve.Evaluate(.5f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + boolKeysCurve.Evaluate(.75f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + boolKeysCurve.Evaluate(1));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + boolKeysCurve.Evaluate(-1f));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + boolKeysCurve.Evaluate(2));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, bool>
        {
            {0, true },
            {50, false },
            {100, true },
        };

        Debug.Log("--> Prueba 3:");
        boolKeysCurve = new BoolKeyframesCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + boolKeysCurve.Evaluate(0));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + boolKeysCurve.Evaluate(.25f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + boolKeysCurve.Evaluate(.5f));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + boolKeysCurve.Evaluate(.75f));
        Assert.AreEqual(false, boolKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + boolKeysCurve.Evaluate(1));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + boolKeysCurve.Evaluate(-1f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + boolKeysCurve.Evaluate(2));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, bool>
        {
            {0, true },
            {20, true },
            {40, true },
            {60, true },
            {80, true },
            {100, true },
        };

        Debug.Log("--> Prueba 3:");
        boolKeysCurve = new BoolKeyframesCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + boolKeysCurve.Evaluate(0));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + boolKeysCurve.Evaluate(.25f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + boolKeysCurve.Evaluate(.5f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + boolKeysCurve.Evaluate(.75f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + boolKeysCurve.Evaluate(1));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + boolKeysCurve.Evaluate(-1f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + boolKeysCurve.Evaluate(2));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, bool>
        {
            {25, true },
        };

        Debug.Log("--> Prueba 1:");
        boolKeysCurve = new BoolKeyframesCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + boolKeysCurve.Evaluate(0));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + boolKeysCurve.Evaluate(.25f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + boolKeysCurve.Evaluate(.5f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + boolKeysCurve.Evaluate(.75f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + boolKeysCurve.Evaluate(1));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + boolKeysCurve.Evaluate(-1f));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + boolKeysCurve.Evaluate(2));
        Assert.AreEqual(true, boolKeysCurve.Evaluate(2));


    }




    [Test]
    public void BoolKeysCurve_WhenInvalidKeysPassed()
    {

        BoolKeyframesCurve boolKeysCurve = null;
        Dictionary<int, bool> keyFrames;



        keyFrames = new Dictionary<int, bool>
        {
            {-2, false },
            {100, true },
        };

        Debug.Log("--> Prueba 1:");
        Assert.Throws<ArgumentOutOfRangeException>(() => new BoolKeyframesCurve(keyFrames, Utween.KeysCurveMode.Step));




        keyFrames = new Dictionary<int, bool>
        {
            {0, false },
            {200, true },
        };

        Debug.Log("--> Prueba 2:");
        Assert.Throws<ArgumentOutOfRangeException>(() => new BoolKeyframesCurve(keyFrames, Utween.KeysCurveMode.Step));





        Assert.Throws<ArgumentException>(() => keyFrames = new Dictionary<int, bool>
        {
            {40, false },
            {40, true },
        });






        keyFrames = new Dictionary<int, bool>
        {
            {-10, false },
            {300, true },
        };

        Debug.Log("--> Prueba 4:");
        Assert.Throws<ArgumentOutOfRangeException>(() => new BoolKeyframesCurve(keyFrames, Utween.KeysCurveMode.Step));





        // When a Key curve badly created is evaluated, it will throw an null reference exception

        try
        {
            keyFrames = new Dictionary<int, bool>
            {
                {-10, false },
                {300, true },
            };

            boolKeysCurve = new BoolKeyframesCurve(keyFrames, Utween.KeysCurveMode.Step);
        }
        catch (Exception)
        {
        }

        Debug.Log("--> Prueba 5:");
        Assert.Throws<NullReferenceException>(() => boolKeysCurve.Evaluate(.25f));

    }


}