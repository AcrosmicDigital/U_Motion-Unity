using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using U.Motion;
using System;

public class Tweens_IntKeysCurve
{


    [Test]
    public void IntKeysCurve_CurveModeSlope()
    {

        IntKeyFramesCurve intKeysCurve;
        Dictionary<int, int> keyFrames;




        keyFrames = new Dictionary<int, int>
        {
            {0, 0 },
            {100, 10 },
        };

        Debug.Log("--> Prueba 1:");
        intKeysCurve = new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + intKeysCurve.Evaluate(0));
        Assert.AreEqual(0, intKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + intKeysCurve.Evaluate(.25f));
        Assert.AreEqual(2, intKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + intKeysCurve.Evaluate(.5f));
        Assert.AreEqual(5, intKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + intKeysCurve.Evaluate(.75f));
        Assert.AreEqual(7, intKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + intKeysCurve.Evaluate(1));
        Assert.AreEqual(10, intKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + intKeysCurve.Evaluate(-1f));
        Assert.AreEqual(0, intKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + intKeysCurve.Evaluate(2));
        Assert.AreEqual(10, intKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, int>
        {
            {0, 0 },
            {50, 10 },
            {100, 0 },
        };

        Debug.Log("--> Prueba 2:");
        intKeysCurve = new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + intKeysCurve.Evaluate(0));
        Assert.AreEqual(0, intKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + intKeysCurve.Evaluate(.25f));
        Assert.AreEqual(5, intKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + intKeysCurve.Evaluate(.5f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + intKeysCurve.Evaluate(.75f));
        Assert.AreEqual(5, intKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + intKeysCurve.Evaluate(1));
        Assert.AreEqual(0, intKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + intKeysCurve.Evaluate(-1f));
        Assert.AreEqual(0, intKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + intKeysCurve.Evaluate(2));
        Assert.AreEqual(0, intKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, int>
        {
            {0, 10 },
            {50, 0 },
            {100, 10 },
        };

        Debug.Log("--> Prueba 3:");
        intKeysCurve = new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + intKeysCurve.Evaluate(0));
        Assert.AreEqual(10, intKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + intKeysCurve.Evaluate(.25f));
        Assert.AreEqual(5, intKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + intKeysCurve.Evaluate(.5f));
        Assert.AreEqual(0, intKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + intKeysCurve.Evaluate(.75f));
        Assert.AreEqual(5, intKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + intKeysCurve.Evaluate(1));
        Assert.AreEqual(10, intKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + intKeysCurve.Evaluate(-1f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + intKeysCurve.Evaluate(2));
        Assert.AreEqual(10, intKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, int>
        {
            {0, -10 },
            {50, 0 },
            {100, 10 },
        };

        Debug.Log("--> Prueba 3:");
        intKeysCurve = new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + intKeysCurve.Evaluate(0));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + intKeysCurve.Evaluate(.25f));
        Assert.AreEqual(-5, intKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + intKeysCurve.Evaluate(.5f));
        Assert.AreEqual(0f, intKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + intKeysCurve.Evaluate(.75f));
        Assert.AreEqual(5, intKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + intKeysCurve.Evaluate(1));
        Assert.AreEqual(10, intKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + intKeysCurve.Evaluate(-1f));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + intKeysCurve.Evaluate(2));
        Assert.AreEqual(10, intKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, int>
        {
            {0, -10 },
            {100, -20 },
        };

        Debug.Log("--> Prueba 3:");
        intKeysCurve = new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + intKeysCurve.Evaluate(0));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + intKeysCurve.Evaluate(.25f));
        Assert.AreEqual(-12, intKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + intKeysCurve.Evaluate(.5f));
        Assert.AreEqual(-15, intKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + intKeysCurve.Evaluate(.75f));
        Assert.AreEqual(-17, intKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + intKeysCurve.Evaluate(1));
        Assert.AreEqual(-20, intKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + intKeysCurve.Evaluate(-1f));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + intKeysCurve.Evaluate(2));
        Assert.AreEqual(-20, intKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, int>
        {
            {0, 10 },
            {20, 10 },
            {40, 10 },
            {60, 10 },
            {80, 10 },
            {100, 10 },
        };

        Debug.Log("--> Prueba 3:");
        intKeysCurve = new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + intKeysCurve.Evaluate(0));
        Assert.AreEqual(10, intKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + intKeysCurve.Evaluate(.25f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + intKeysCurve.Evaluate(.5f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + intKeysCurve.Evaluate(.75f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + intKeysCurve.Evaluate(1));
        Assert.AreEqual(10, intKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + intKeysCurve.Evaluate(-1f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + intKeysCurve.Evaluate(2));
        Assert.AreEqual(10, intKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, int>
        {
            {0, -10 },
            {20, -10 },
            {40, -10 },
            {60, -10 },
            {80, -10 },
            {100, -10 },
        };

        Debug.Log("--> Prueba 3:");
        intKeysCurve = new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + intKeysCurve.Evaluate(0));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + intKeysCurve.Evaluate(.25f));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + intKeysCurve.Evaluate(.5f));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + intKeysCurve.Evaluate(.75f));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + intKeysCurve.Evaluate(1));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + intKeysCurve.Evaluate(-1f));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + intKeysCurve.Evaluate(2));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, int>
        {
            {25, 10 },
        };

        Debug.Log("--> Prueba 1:");
        intKeysCurve = new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Slope);
        Debug.Log("P: 0 = " + intKeysCurve.Evaluate(0));
        Assert.AreEqual(10, intKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + intKeysCurve.Evaluate(.25f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + intKeysCurve.Evaluate(.5f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + intKeysCurve.Evaluate(.75f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + intKeysCurve.Evaluate(1));
        Assert.AreEqual(10, intKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + intKeysCurve.Evaluate(-1f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + intKeysCurve.Evaluate(2));
        Assert.AreEqual(10, intKeysCurve.Evaluate(2));


    }




    [Test]
    public void IntKeysCurve_CurveModeStep()
    {

        IntKeyFramesCurve intKeysCurve;
        Dictionary<int, int> keyFrames;




        keyFrames = new Dictionary<int, int>
        {
            {0, 0 },
            {100, 10 },
        };

        Debug.Log("--> Prueba 1:");
        intKeysCurve = new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + intKeysCurve.Evaluate(0));
        Assert.AreEqual(0, intKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + intKeysCurve.Evaluate(.25f));
        Assert.AreEqual(0, intKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + intKeysCurve.Evaluate(.5f));
        Assert.AreEqual(0, intKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + intKeysCurve.Evaluate(.75f));
        Assert.AreEqual(0, intKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + intKeysCurve.Evaluate(1));
        Assert.AreEqual(10, intKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + intKeysCurve.Evaluate(-1f));
        Assert.AreEqual(0, intKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + intKeysCurve.Evaluate(2));
        Assert.AreEqual(10, intKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, int>
        {
            {0, 0 },
            {50, 10 },
            {100, 0 },
        };

        Debug.Log("--> Prueba 2:");
        intKeysCurve = new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + intKeysCurve.Evaluate(0));
        Assert.AreEqual(0, intKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + intKeysCurve.Evaluate(.25f));
        Assert.AreEqual(0, intKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + intKeysCurve.Evaluate(.5f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + intKeysCurve.Evaluate(.75f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + intKeysCurve.Evaluate(1));
        Assert.AreEqual(0, intKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + intKeysCurve.Evaluate(-1f));
        Assert.AreEqual(0, intKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + intKeysCurve.Evaluate(2));
        Assert.AreEqual(0, intKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, int>
        {
            {0, 10 },
            {50, 0 },
            {100, 10 },
        };

        Debug.Log("--> Prueba 3:");
        intKeysCurve = new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + intKeysCurve.Evaluate(0));
        Assert.AreEqual(10, intKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + intKeysCurve.Evaluate(.25f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + intKeysCurve.Evaluate(.5f));
        Assert.AreEqual(0, intKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + intKeysCurve.Evaluate(.75f));
        Assert.AreEqual(0, intKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + intKeysCurve.Evaluate(1));
        Assert.AreEqual(10, intKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + intKeysCurve.Evaluate(-1f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + intKeysCurve.Evaluate(2));
        Assert.AreEqual(10, intKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, int>
        {
            {0, -10 },
            {50, 0 },
            {100, 10 },
        };

        Debug.Log("--> Prueba 3:");
        intKeysCurve = new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + intKeysCurve.Evaluate(0));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + intKeysCurve.Evaluate(.25f));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + intKeysCurve.Evaluate(.5f));
        Assert.AreEqual(0f, intKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + intKeysCurve.Evaluate(.75f));
        Assert.AreEqual(0, intKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + intKeysCurve.Evaluate(1));
        Assert.AreEqual(10, intKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + intKeysCurve.Evaluate(-1f));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + intKeysCurve.Evaluate(2));
        Assert.AreEqual(10, intKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, int>
        {
            {0, -10 },
            {100, -20 },
        };

        Debug.Log("--> Prueba 3:");
        intKeysCurve = new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + intKeysCurve.Evaluate(0));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + intKeysCurve.Evaluate(.25f));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + intKeysCurve.Evaluate(.5f));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + intKeysCurve.Evaluate(.75f));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + intKeysCurve.Evaluate(1));
        Assert.AreEqual(-20, intKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + intKeysCurve.Evaluate(-1f));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + intKeysCurve.Evaluate(2));
        Assert.AreEqual(-20, intKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, int>
        {
            {0, 10 },
            {20, 10 },
            {40, 10 },
            {60, 10 },
            {80, 10 },
            {100, 10 },
        };

        Debug.Log("--> Prueba 3:");
        intKeysCurve = new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + intKeysCurve.Evaluate(0));
        Assert.AreEqual(10, intKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + intKeysCurve.Evaluate(.25f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + intKeysCurve.Evaluate(.5f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + intKeysCurve.Evaluate(.75f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + intKeysCurve.Evaluate(1));
        Assert.AreEqual(10, intKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + intKeysCurve.Evaluate(-1f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + intKeysCurve.Evaluate(2));
        Assert.AreEqual(10, intKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, int>
        {
            {0, -10 },
            {20, -10 },
            {40, -10 },
            {60, -10 },
            {80, -10 },
            {100, -10 },
        };

        Debug.Log("--> Prueba 3:");
        intKeysCurve = new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + intKeysCurve.Evaluate(0));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + intKeysCurve.Evaluate(.25f));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + intKeysCurve.Evaluate(.5f));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + intKeysCurve.Evaluate(.75f));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + intKeysCurve.Evaluate(1));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + intKeysCurve.Evaluate(-1f));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + intKeysCurve.Evaluate(2));
        Assert.AreEqual(-10, intKeysCurve.Evaluate(2));




        keyFrames = new Dictionary<int, int>
        {
            {25, 10 },
        };

        Debug.Log("--> Prueba 1:");
        intKeysCurve = new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Step);
        Debug.Log("P: 0 = " + intKeysCurve.Evaluate(0));
        Assert.AreEqual(10, intKeysCurve.Evaluate(0));
        Debug.Log("P: .25 = " + intKeysCurve.Evaluate(.25f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(.25f));
        Debug.Log("P: .5 = " + intKeysCurve.Evaluate(.5f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(.5f));
        Debug.Log("P: .75 = " + intKeysCurve.Evaluate(.75f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(.75f));
        Debug.Log("P: 1 = " + intKeysCurve.Evaluate(1));
        Assert.AreEqual(10, intKeysCurve.Evaluate(1));

        Debug.Log("P: -1 = " + intKeysCurve.Evaluate(-1f));
        Assert.AreEqual(10, intKeysCurve.Evaluate(-1f));
        Debug.Log("P: 2 = " + intKeysCurve.Evaluate(2));
        Assert.AreEqual(10, intKeysCurve.Evaluate(2));


    }




    [Test]
    public void IntKeysCurve_WhenInvalidKeysPassed()
    {

        IntKeyFramesCurve intKeysCurve = null;
        Dictionary<int, int> keyFrames;



        keyFrames = new Dictionary<int, int>
        {
            {-2, 0 },
            {100, 10 },
        };

        Debug.Log("--> Prueba 1:");
        Assert.Throws<ArgumentOutOfRangeException>(() => new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Step));




        keyFrames = new Dictionary<int, int>
        {
            {0, 0 },
            {200, 10 },
        };

        Debug.Log("--> Prueba 2:");
        Assert.Throws<ArgumentOutOfRangeException>(() => new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Step));





        Assert.Throws<ArgumentException>(() => keyFrames = new Dictionary<int, int>
        {
            {40, 0 },
            {40, 1 },
        });






        keyFrames = new Dictionary<int, int>
        {
            {-10, 0 },
            {300, 10 },
        };

        Debug.Log("--> Prueba 4:");
        Assert.Throws<ArgumentOutOfRangeException>(() => new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Step));





        // When a Key curve badly created is evaluated, it will throw an null reference exception

        try
        {
            keyFrames = new Dictionary<int, int>
            {
                {-10, 0 },
                {300, 10 },
            };

            intKeysCurve = new IntKeyFramesCurve(keyFrames, Uanimation.KeysCurveMode.Step);
        }
        catch (Exception)
        {
        }

        Debug.Log("--> Prueba 5:");
        Assert.Throws<NullReferenceException>(() => intKeysCurve.Evaluate(.25f));

    }


}
