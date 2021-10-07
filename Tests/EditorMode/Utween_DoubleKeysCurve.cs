using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using U.Motion;
using System;

public class Utween_DoubleKeysCurve
{


    [Test]
    public void DoubleKeysCurve_CurveModeSlope()
    {

        

        DoubleKeyFramesCurve doubleKeysCurve;
        Dictionary<int, double> keyFrames;




        keyFrames = new Dictionary<int, double>
        {
            {0, 0 },
            {100, 1 },
        };

        Debug.Log("--> Prueba 1:");
        doubleKeysCurve = new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + doubleKeysCurve.Evaluate(0));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + doubleKeysCurve.Evaluate(.25f));
        Assert.AreEqual(.25d, doubleKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + doubleKeysCurve.Evaluate(.5f));
        Assert.AreEqual(.5d, doubleKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + doubleKeysCurve.Evaluate(.75f));
        Assert.AreEqual(.75d, doubleKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + doubleKeysCurve.Evaluate(1));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + doubleKeysCurve.Evaluate(-1f));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + doubleKeysCurve.Evaluate(2));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, double>
        {
            {0, 0 },
            {50, 1 },
            {100, 0 },
        };

        Debug.Log("--> Prueba 2:");
        doubleKeysCurve = new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + doubleKeysCurve.Evaluate(0));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + doubleKeysCurve.Evaluate(.25f));
        Assert.AreEqual(.5d, doubleKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + doubleKeysCurve.Evaluate(.5f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + doubleKeysCurve.Evaluate(.75f));
        Assert.AreEqual(.5d, doubleKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + doubleKeysCurve.Evaluate(1));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + doubleKeysCurve.Evaluate(-1f));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + doubleKeysCurve.Evaluate(2));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, double>
        {
            {0, 1 },
            {50, 0 },
            {100, 1 },
        };

        Debug.Log("--> Prueba 3:");
        doubleKeysCurve = new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + doubleKeysCurve.Evaluate(0));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + doubleKeysCurve.Evaluate(.25f));
        Assert.AreEqual(.5d, doubleKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + doubleKeysCurve.Evaluate(.5f));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + doubleKeysCurve.Evaluate(.75f));
        Assert.AreEqual(.5d, doubleKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + doubleKeysCurve.Evaluate(1));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + doubleKeysCurve.Evaluate(-1f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + doubleKeysCurve.Evaluate(2));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, double>
        {
            {0, -1 },
            {50, 0 },
            {100, 1 },
        };

        Debug.Log("--> Prueba 3:");
        doubleKeysCurve = new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + doubleKeysCurve.Evaluate(0));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + doubleKeysCurve.Evaluate(.25f));
        Assert.AreEqual(-.5d, doubleKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + doubleKeysCurve.Evaluate(.5f));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + doubleKeysCurve.Evaluate(.75f));
        Assert.AreEqual(.5d, doubleKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + doubleKeysCurve.Evaluate(1));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + doubleKeysCurve.Evaluate(-1f));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + doubleKeysCurve.Evaluate(2));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, double>
        {
            {0, -1 },
            {100, -2 },
        };

        Debug.Log("--> Prueba 3:");
        doubleKeysCurve = new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + doubleKeysCurve.Evaluate(0));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + doubleKeysCurve.Evaluate(.25f));
        Assert.AreEqual(-1.25d, doubleKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + doubleKeysCurve.Evaluate(.5f));
        Assert.AreEqual(-1.5d, doubleKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + doubleKeysCurve.Evaluate(.75f));
        Assert.AreEqual(-1.75d, doubleKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + doubleKeysCurve.Evaluate(1));
        Assert.AreEqual(-2d, doubleKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + doubleKeysCurve.Evaluate(-1f));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + doubleKeysCurve.Evaluate(2));
        Assert.AreEqual(-2d, doubleKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, double>
        {
            {0, 1 },
            {20, 1 },
            {40, 1 },
            {60, 1 },
            {80, 1 },
            {100, 1 },
        };

        Debug.Log("--> Prueba 3:");
        doubleKeysCurve = new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + doubleKeysCurve.Evaluate(0));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + doubleKeysCurve.Evaluate(.25f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + doubleKeysCurve.Evaluate(.5f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + doubleKeysCurve.Evaluate(.75f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + doubleKeysCurve.Evaluate(1));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + doubleKeysCurve.Evaluate(-1f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + doubleKeysCurve.Evaluate(2));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, double>
        {
            {0, -1 },
            {20, -1 },
            {40, -1 },
            {60, -1 },
            {80, -1 },
            {100, -1 },
        };

        Debug.Log("--> Prueba 3:");
        doubleKeysCurve = new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + doubleKeysCurve.Evaluate(0));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + doubleKeysCurve.Evaluate(.25f));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + doubleKeysCurve.Evaluate(.5f));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + doubleKeysCurve.Evaluate(.75f));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + doubleKeysCurve.Evaluate(1));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + doubleKeysCurve.Evaluate(-1f));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + doubleKeysCurve.Evaluate(2));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, double>
        {
            {25, 1 },
        };

        Debug.Log("--> Prueba 1:");
        doubleKeysCurve = new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + doubleKeysCurve.Evaluate(0));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + doubleKeysCurve.Evaluate(.25f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + doubleKeysCurve.Evaluate(.5f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + doubleKeysCurve.Evaluate(.75f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + doubleKeysCurve.Evaluate(1));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + doubleKeysCurve.Evaluate(-1f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + doubleKeysCurve.Evaluate(2));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(2));


    }




    [Test]
    public void DoubleKeysCurve_CurveModeStep()
    {

        DoubleKeyFramesCurve doubleKeysCurve;
        Dictionary<int, double> keyFrames;




        keyFrames = new Dictionary<int, double>
        {
            {0, 0 },
            {100, 1 },
        };

        Debug.Log("--> Prueba 1:");
        doubleKeysCurve = new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + doubleKeysCurve.Evaluate(0));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + doubleKeysCurve.Evaluate(.25f));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + doubleKeysCurve.Evaluate(.5f));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + doubleKeysCurve.Evaluate(.75f));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + doubleKeysCurve.Evaluate(1));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + doubleKeysCurve.Evaluate(-1f));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + doubleKeysCurve.Evaluate(2));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, double>
        {
            {0, 0 },
            {50, 1 },
            {100, 0 },
        };

        Debug.Log("--> Prueba 2:");
        doubleKeysCurve = new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + doubleKeysCurve.Evaluate(0));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + doubleKeysCurve.Evaluate(.25f));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + doubleKeysCurve.Evaluate(.5f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + doubleKeysCurve.Evaluate(.75f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + doubleKeysCurve.Evaluate(1));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + doubleKeysCurve.Evaluate(-1f));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + doubleKeysCurve.Evaluate(2));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, double>
        {
            {0, 1 },
            {50, 0 },
            {100, 1 },
        };

        Debug.Log("--> Prueba 3:");
        doubleKeysCurve = new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + doubleKeysCurve.Evaluate(0));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + doubleKeysCurve.Evaluate(.25f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + doubleKeysCurve.Evaluate(.5f));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + doubleKeysCurve.Evaluate(.75f));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + doubleKeysCurve.Evaluate(1));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + doubleKeysCurve.Evaluate(-1f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + doubleKeysCurve.Evaluate(2));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, double>
        {
            {0, -1 },
            {50, 0 },
            {100, 1 },
        };

        Debug.Log("--> Prueba 3:");
        doubleKeysCurve = new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + doubleKeysCurve.Evaluate(0));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + doubleKeysCurve.Evaluate(.25f));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + doubleKeysCurve.Evaluate(.5f));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + doubleKeysCurve.Evaluate(.75f));
        Assert.AreEqual(0d, doubleKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + doubleKeysCurve.Evaluate(1));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + doubleKeysCurve.Evaluate(-1f));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + doubleKeysCurve.Evaluate(2));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, double>
        {
            {0, -1 },
            {100, -2 },
        };

        Debug.Log("--> Prueba 3:");
        doubleKeysCurve = new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + doubleKeysCurve.Evaluate(0));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + doubleKeysCurve.Evaluate(.25f));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + doubleKeysCurve.Evaluate(.5f));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + doubleKeysCurve.Evaluate(.75f));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + doubleKeysCurve.Evaluate(1));
        Assert.AreEqual(-2d, doubleKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + doubleKeysCurve.Evaluate(-1f));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + doubleKeysCurve.Evaluate(2));
        Assert.AreEqual(-2d, doubleKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, double>
        {
            {0, 1 },
            {20, 1 },
            {40, 1 },
            {60, 1 },
            {80, 1 },
            {100, 1 },
        };

        Debug.Log("--> Prueba 3:");
        doubleKeysCurve = new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + doubleKeysCurve.Evaluate(0));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + doubleKeysCurve.Evaluate(.25f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + doubleKeysCurve.Evaluate(.5f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + doubleKeysCurve.Evaluate(.75f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + doubleKeysCurve.Evaluate(1));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + doubleKeysCurve.Evaluate(-1f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + doubleKeysCurve.Evaluate(2));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, double>
        {
            {0, -1 },
            {20, -1 },
            {40, -1 },
            {60, -1 },
            {80, -1 },
            {100, -1 },
        };

        Debug.Log("--> Prueba 3:");
        doubleKeysCurve = new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + doubleKeysCurve.Evaluate(0));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + doubleKeysCurve.Evaluate(.25f));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + doubleKeysCurve.Evaluate(.5f));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + doubleKeysCurve.Evaluate(.75f));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + doubleKeysCurve.Evaluate(1));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + doubleKeysCurve.Evaluate(-1f));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + doubleKeysCurve.Evaluate(2));
        Assert.AreEqual(-1d, doubleKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, double>
        {
            {25, 1 },
        };

        Debug.Log("--> Prueba 1:");
        doubleKeysCurve = new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + doubleKeysCurve.Evaluate(0));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + doubleKeysCurve.Evaluate(.25f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + doubleKeysCurve.Evaluate(.5f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + doubleKeysCurve.Evaluate(.75f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + doubleKeysCurve.Evaluate(1));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + doubleKeysCurve.Evaluate(-1f));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + doubleKeysCurve.Evaluate(2));
        Assert.AreEqual(1d, doubleKeysCurve.Evaluate(2));


    }




    [Test]
    public void DoubleKeysCurve_WhenInvalidKeysPassed()
    {

        DoubleKeyFramesCurve doubleKeysCurve = null;
        Dictionary<int, double> keyFrames;



        keyFrames = new Dictionary<int, double>
        {
            {-2, 0 },
            {100, 1 },
        };

        Debug.Log("--> Prueba 1:");
        Assert.Throws<ArgumentOutOfRangeException>(() => new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Step));




        keyFrames = new Dictionary<int, double>
        {
            {0, 0 },
            {200, 1 },
        };

        Debug.Log("--> Prueba 2:");
        Assert.Throws<ArgumentOutOfRangeException>(() => new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Step));





        Assert.Throws<ArgumentException>(() => keyFrames = new Dictionary<int, double>
        {
            {40, 0 },
            {40, 1 },
        });






        keyFrames = new Dictionary<int, double>
        {
            {-10, 0 },
            {300, 1 },
        };

        Debug.Log("--> Prueba 4:");
        Assert.Throws<ArgumentOutOfRangeException>(() => new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Step));





        // When a Key curve badly created is evaluated, it will throw an null reference exception

        try
        {
            keyFrames = new Dictionary<int, double>
            {
                {-10, 0 },
                {300, 1 },
            };

            doubleKeysCurve = new DoubleKeyFramesCurve(keyFrames, Utween.KeysCurveMode.Step);
        }
        catch (Exception)
        {
        }

        Debug.Log("--> Prueba 5:");
        Assert.Throws<NullReferenceException>(() => doubleKeysCurve.Evaluate(.25f));

    }


}
