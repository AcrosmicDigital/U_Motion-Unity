using NUnit.Framework;
using System;
using System.Collections.Generic;
using U.Motion;
using UnityEngine;

public class Utween_TimeCurve
{

    [Test]
    public void TimeCurve_WhenValidKeysPasses()
    {
        EaseCurve timeCurve = null;
        Keyframe[] keyFrames;


        keyFrames = new Keyframe[]
        {
            new Keyframe(0f, 0),
            new Keyframe(.23f, 1),
        };

        Debug.Log("--> Prueba 1:");
        timeCurve = new EaseCurve(keyFrames);

        keyFrames = new Keyframe[]
        {
            new Keyframe(0f, 0),
            new Keyframe(1f, 1),
        };

        Debug.Log("--> Prueba 2:");
        timeCurve = new EaseCurve(keyFrames);

        keyFrames = new Keyframe[]
        {
            new Keyframe(0f, 0),
            new Keyframe(1f, 1),
        };

    }


    [Test]
    public void TimeCurve_PredefinedCurves()
    {

        EaseCurve[] timeCurves = new EaseCurve[]
        {
            EaseCurve.easeInOut,
            EaseCurve.easeIn,
            EaseCurve.easeOut,
            EaseCurve.circInOut,
            EaseCurve.circIn,
            EaseCurve.circOut,
            EaseCurve.fast,
            EaseCurve.sine,
            EaseCurve.bisine,
        };
        //

        foreach (var timeCurve in timeCurves)
        {

            Debug.Log("--> Prueba: ");

            for (float i = 0; i <= 1 ; i+=.01f)
                timeCurve.Evaluate(i);

            Debug.Log("P: -1 = " + timeCurve.Evaluate(-1f));
            Assert.AreEqual(0f, timeCurve.Evaluate(-1f));
            Debug.Log("P: 2 = " + timeCurve.Evaluate(2));
            Assert.AreEqual(1f, timeCurve.Evaluate(2));
        }



    }


    [Test]
    public void TimeCurve_WhenInvalidKeysPasses()
    {

        EaseCurve timeCurve = null;
        Keyframe[] keyFrames;



        keyFrames = new Keyframe[]
        {
            new Keyframe(-.1f, 0),
            new Keyframe(.23f, 1),
        };

        Debug.Log("--> Prueba 1:");
        Assert.Throws<ArgumentOutOfRangeException>(() => new EaseCurve(keyFrames));




        keyFrames = new Keyframe[]
        {
            new Keyframe(0, 0),
            new Keyframe(1.1f, 1),
        };

        Debug.Log("--> Prueba 2:");
        Assert.Throws<ArgumentOutOfRangeException>(() => new EaseCurve(keyFrames));






        keyFrames = new Keyframe[]
        {
            new Keyframe(-1, 0),
            new Keyframe(1.1f, 1),
        };

        Debug.Log("--> Prueba 4:");
        Assert.Throws<ArgumentOutOfRangeException>(() => new EaseCurve(keyFrames));





        // When a Key curve badly created is evaluated, it will throw an null reference exception

        try
        {
            keyFrames = new Keyframe[]
            {
                new Keyframe(-.1f, 0),
                new Keyframe(.3f, 0),
            };

            timeCurve = new EaseCurve(keyFrames);
        }
        catch (Exception)
        {
        }

        Debug.Log("--> Prueba 5:");
        Assert.Throws<NullReferenceException>(() => timeCurve.Evaluate(.25f));

    }

}
