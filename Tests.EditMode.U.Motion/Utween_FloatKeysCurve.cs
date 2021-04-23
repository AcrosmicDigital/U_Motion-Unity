using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using U.Motion;
using System;

public class Utween_FloatKeysCurve
{
    

    [Test]
    public void FloatKeysCurve_CurveModeSlope()
    {

        FloatKeysCurve floatKeysCurve;
        Dictionary<int, float> keyFrames;




        keyFrames = new Dictionary<int, float>
        {
            {0, 0 },
            {100, 1 },
        };

        Debug.Log("--> Prueba 1:");
        floatKeysCurve = new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + floatKeysCurve.Evaluate(0));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + floatKeysCurve.Evaluate(.25f));
        Assert.AreEqual(.25f, floatKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + floatKeysCurve.Evaluate(.5f));
        Assert.AreEqual(.5f, floatKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + floatKeysCurve.Evaluate(.75f));
        Assert.AreEqual(.75f, floatKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + floatKeysCurve.Evaluate(1));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + floatKeysCurve.Evaluate(-1f));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + floatKeysCurve.Evaluate(2));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, float>
        {
            {0, 0 },
            {50, 1 },
            {100, 0 },
        };

        Debug.Log("--> Prueba 2:");
        floatKeysCurve = new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + floatKeysCurve.Evaluate(0));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + floatKeysCurve.Evaluate(.25f));
        Assert.AreEqual(.5f, floatKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + floatKeysCurve.Evaluate(.5f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + floatKeysCurve.Evaluate(.75f));
        Assert.AreEqual(.5f, floatKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + floatKeysCurve.Evaluate(1));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + floatKeysCurve.Evaluate(-1f));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + floatKeysCurve.Evaluate(2));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, float>
        {
            {0, 1 },
            {50, 0 },
            {100, 1 },
        };

        Debug.Log("--> Prueba 3:");
        floatKeysCurve = new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + floatKeysCurve.Evaluate(0));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + floatKeysCurve.Evaluate(.25f));
        Assert.AreEqual(.5f, floatKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + floatKeysCurve.Evaluate(.5f));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + floatKeysCurve.Evaluate(.75f));
        Assert.AreEqual(.5f, floatKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + floatKeysCurve.Evaluate(1));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + floatKeysCurve.Evaluate(-1f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + floatKeysCurve.Evaluate(2));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, float>
        {
            {0, -1 },
            {50, 0 },
            {100, 1 },
        };

        Debug.Log("--> Prueba 3:");
        floatKeysCurve = new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + floatKeysCurve.Evaluate(0));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + floatKeysCurve.Evaluate(.25f));
        Assert.AreEqual(-.5f, floatKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + floatKeysCurve.Evaluate(.5f));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + floatKeysCurve.Evaluate(.75f));
        Assert.AreEqual(.5f, floatKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + floatKeysCurve.Evaluate(1));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + floatKeysCurve.Evaluate(-1f));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + floatKeysCurve.Evaluate(2));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, float>
        {
            {0, -1 },
            {100, -2 },
        };

        Debug.Log("--> Prueba 3:");
        floatKeysCurve = new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + floatKeysCurve.Evaluate(0));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + floatKeysCurve.Evaluate(.25f));
        Assert.AreEqual(-1.25f, floatKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + floatKeysCurve.Evaluate(.5f));
        Assert.AreEqual(-1.5f, floatKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + floatKeysCurve.Evaluate(.75f));
        Assert.AreEqual(-1.75f, floatKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + floatKeysCurve.Evaluate(1));
        Assert.AreEqual(-2f, floatKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + floatKeysCurve.Evaluate(-1f));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + floatKeysCurve.Evaluate(2));
        Assert.AreEqual(-2f, floatKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, float>
        {
            {0, 1 },
            {20, 1 },
            {40, 1 },
            {60, 1 },
            {80, 1 },
            {100, 1 },
        };

        Debug.Log("--> Prueba 3:");
        floatKeysCurve = new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + floatKeysCurve.Evaluate(0));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + floatKeysCurve.Evaluate(.25f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + floatKeysCurve.Evaluate(.5f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + floatKeysCurve.Evaluate(.75f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + floatKeysCurve.Evaluate(1));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + floatKeysCurve.Evaluate(-1f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + floatKeysCurve.Evaluate(2));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, float>
        {
            {0, -1 },
            {20, -1 },
            {40, -1 },
            {60, -1 },
            {80, -1 },
            {100, -1 },
        };

        Debug.Log("--> Prueba 3:");
        floatKeysCurve = new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + floatKeysCurve.Evaluate(0));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + floatKeysCurve.Evaluate(.25f));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + floatKeysCurve.Evaluate(.5f));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + floatKeysCurve.Evaluate(.75f));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + floatKeysCurve.Evaluate(1));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + floatKeysCurve.Evaluate(-1f));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + floatKeysCurve.Evaluate(2));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, float>
        {
            {25, 1 },
        };

        Debug.Log("--> Prueba 1:");
        floatKeysCurve = new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + floatKeysCurve.Evaluate(0));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + floatKeysCurve.Evaluate(.25f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + floatKeysCurve.Evaluate(.5f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + floatKeysCurve.Evaluate(.75f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + floatKeysCurve.Evaluate(1));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + floatKeysCurve.Evaluate(-1f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + floatKeysCurve.Evaluate(2));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(2));


    }




    [Test]
    public void FloatKeysCurve_CurveModeStep()
    {

        FloatKeysCurve floatKeysCurve;
        Dictionary<int, float> keyFrames;




        keyFrames = new Dictionary<int, float>
        {
            {0, 0 },
            {100, 1 },
        };

        Debug.Log("--> Prueba 1:");
        floatKeysCurve = new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + floatKeysCurve.Evaluate(0));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + floatKeysCurve.Evaluate(.25f));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + floatKeysCurve.Evaluate(.5f));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + floatKeysCurve.Evaluate(.75f));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + floatKeysCurve.Evaluate(1));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + floatKeysCurve.Evaluate(-1f));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + floatKeysCurve.Evaluate(2));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, float>
        {
            {0, 0 },
            {50, 1 },
            {100, 0 },
        };

        Debug.Log("--> Prueba 2:");
        floatKeysCurve = new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + floatKeysCurve.Evaluate(0));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + floatKeysCurve.Evaluate(.25f));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + floatKeysCurve.Evaluate(.5f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + floatKeysCurve.Evaluate(.75f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + floatKeysCurve.Evaluate(1));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + floatKeysCurve.Evaluate(-1f));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + floatKeysCurve.Evaluate(2));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, float>
        {
            {0, 1 },
            {50, 0 },
            {100, 1 },
        };

        Debug.Log("--> Prueba 3:");
        floatKeysCurve = new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + floatKeysCurve.Evaluate(0));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + floatKeysCurve.Evaluate(.25f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + floatKeysCurve.Evaluate(.5f));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + floatKeysCurve.Evaluate(.75f));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + floatKeysCurve.Evaluate(1));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + floatKeysCurve.Evaluate(-1f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + floatKeysCurve.Evaluate(2));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, float>
        {
            {0, -1 },
            {50, 0 },
            {100, 1 },
        };

        Debug.Log("--> Prueba 3:");
        floatKeysCurve = new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + floatKeysCurve.Evaluate(0));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + floatKeysCurve.Evaluate(.25f));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + floatKeysCurve.Evaluate(.5f));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + floatKeysCurve.Evaluate(.75f));
        Assert.AreEqual(0f, floatKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + floatKeysCurve.Evaluate(1));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + floatKeysCurve.Evaluate(-1f));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + floatKeysCurve.Evaluate(2));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, float>
        {
            {0, -1 },
            {100, -2 },
        };

        Debug.Log("--> Prueba 3:");
        floatKeysCurve = new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + floatKeysCurve.Evaluate(0));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + floatKeysCurve.Evaluate(.25f));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + floatKeysCurve.Evaluate(.5f));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + floatKeysCurve.Evaluate(.75f));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + floatKeysCurve.Evaluate(1));
        Assert.AreEqual(-2f, floatKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + floatKeysCurve.Evaluate(-1f));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + floatKeysCurve.Evaluate(2));
        Assert.AreEqual(-2f, floatKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, float>
        {
            {0, 1 },
            {20, 1 },
            {40, 1 },
            {60, 1 },
            {80, 1 },
            {100, 1 },
        };

        Debug.Log("--> Prueba 3:");
        floatKeysCurve = new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + floatKeysCurve.Evaluate(0));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + floatKeysCurve.Evaluate(.25f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + floatKeysCurve.Evaluate(.5f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + floatKeysCurve.Evaluate(.75f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + floatKeysCurve.Evaluate(1));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + floatKeysCurve.Evaluate(-1f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + floatKeysCurve.Evaluate(2));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, float>
        {
            {0, -1 },
            {20, -1 },
            {40, -1 },
            {60, -1 },
            {80, -1 },
            {100, -1 },
        };

        Debug.Log("--> Prueba 3:");
        floatKeysCurve = new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + floatKeysCurve.Evaluate(0));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + floatKeysCurve.Evaluate(.25f));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + floatKeysCurve.Evaluate(.5f));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + floatKeysCurve.Evaluate(.75f));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + floatKeysCurve.Evaluate(1));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + floatKeysCurve.Evaluate(-1f));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + floatKeysCurve.Evaluate(2));
        Assert.AreEqual(-1f, floatKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, float>
        {
            {25, 1 },
        };

        Debug.Log("--> Prueba 1:");
        floatKeysCurve = new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + floatKeysCurve.Evaluate(0));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + floatKeysCurve.Evaluate(.25f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + floatKeysCurve.Evaluate(.5f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + floatKeysCurve.Evaluate(.75f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + floatKeysCurve.Evaluate(1));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + floatKeysCurve.Evaluate(-1f));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + floatKeysCurve.Evaluate(2));
        Assert.AreEqual(1f, floatKeysCurve.Evaluate(2));


    }




    [Test]
    public void FloatKeysCurve_WhenInvalidKeysPassed()
    {

        FloatKeysCurve floatKeysCurve = null;
        Dictionary<int, float> keyFrames;



        keyFrames = new Dictionary<int, float>
        {
            {-2, 0 },
            {100, 1 },
        };

        Debug.Log("--> Prueba 1:");
        Assert.Throws<ArgumentOutOfRangeException>(() => new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Step));




        keyFrames = new Dictionary<int, float>
        {
            {0, 0 },
            {200, 1 },
        };

        Debug.Log("--> Prueba 2:");
        Assert.Throws<ArgumentOutOfRangeException>(() => new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Step));




        
        Assert.Throws<ArgumentException>(() => keyFrames = new Dictionary<int, float>
        {
            {40, 0 },
            {40, 1 },
        });






        keyFrames = new Dictionary<int, float>
        {
            {-10, 0 },
            {300, 1 },
        };

        Debug.Log("--> Prueba 4:");
        Assert.Throws<ArgumentOutOfRangeException>(() => new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Step));





        // When a Key curve badly created is evaluated, it will throw an null reference exception

        try
        {
            keyFrames = new Dictionary<int, float>
            {
                {-10, 0 },
                {300, 1 },
            };

            floatKeysCurve = new FloatKeysCurve(keyFrames, Utween.KeysCurveMode.Step);
        }
        catch (Exception)
        {
        }

        Debug.Log("--> Prueba 5:");
        Assert.Throws<NullReferenceException>(() => floatKeysCurve.Evaluate(.25f));

    }


}
