using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using U.Motion;
using UnityEngine;
using UnityEngine.TestTools;

public class Utween_TweenFloat_Iterations
{

    int frameRate = 30;

    [OneTimeSetUp]
    public void SetUp()
    {
        frameRate = Application.targetFrameRate;
    }

    [TearDown]
    public void TierDown()
    {
        Time.timeScale = 1;
        Application.targetFrameRate = frameRate;
    }



    [UnityTest]
    public IEnumerator TweenFloat_CheckIterations()
    {

        // Host and client 
        GameObject host = new GameObject("Host");
        float client = 0;

        // Keyframes for the animation
        var keyframes = new Dictionary<int, float>
        {
            {0, client},
            {50, 3f},
            {100, 20f},
        };

        // Function to set the value to the client
        void Animate(float x)
        {
            Debug.Log(x);
            client = x;
        }

        // Animation Params
        var animationParams = new TimeAnimationParams
        {
            // Set        // Default
            // delay = 3, // delay = 0,
            //direction = Utween.Direction.Normal,
            //duration = 2,
            //fillMode = Utween.FillMode.Both,
            iterations = 4,  //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Create the animation
        Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(7.9f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(1f);
        Assert.AreEqual(20f, client);

    }



    [UnityTest]
    public IEnumerator TweenFloat_BCheckIterationsAndDelay()
    {

        // Host and client 
        GameObject host = new GameObject("Host");
        float client = 0;

        // Keyframes for the animation
        var keyframes = new Dictionary<int, float>
        {
            {0, client},
            {50, 3f},
            {100, 20f},
        };

        // Function to set the value to the client
        void Animate(float x)
        {
            Debug.Log(x);
            client = x;
        }

        // Animation Params
        var animationParams = new TimeAnimationParams
        {
            // Set        // Default
            delay = 2, // delay = 0,
            //direction = Utween.Direction.Normal,
            //duration = 2,
            //fillMode = Utween.FillMode.Both,
            iterations = 4,  //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Create the animation
        Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // Because of the delay the animation will not start inmediatly
        yield return new WaitForSecondsRealtime(1.9f);
        Assert.AreEqual(0f, client);

        // The animation will start
        yield return new WaitForSecondsRealtime(7.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);

    }


    [UnityTest]
    public IEnumerator TweenFloat_DCheckIterationsAndPause()
    {

        // Host and client 
        GameObject host = new GameObject("Host");
        float client = 0;

        // Keyframes for the animation
        var keyframes = new Dictionary<int, float>
        {
            {0, client},
            {50, 3f},
            {100, 20f},
        };

        // Function to set the value to the client
        void Animate(float x)
        {
            Debug.Log(x);
            client = x;
        }

        // Animation Params
        var animationParams = new TimeAnimationParams
        {
            // Set        // Default
            delay = 2, // delay = 0,
            //direction = Utween.Direction.Normal,
            //duration = 2,
            //fillMode = Utween.FillMode.Both,
            iterations = 4,  //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Create the animation
        var tween = Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // Pause the animation
        tween.Pause();
        yield return new WaitForSecondsRealtime(3f);
        tween.Resume();

        // Because of the delay the animation will not start inmediatly
        yield return new WaitForSecondsRealtime(1.9f);
        Assert.AreEqual(0f, client);

        // The animation will start
        yield return new WaitForSecondsRealtime(7.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);

    }



    [UnityTest]
    public IEnumerator TweenFloat_DCheckIterationsAndRepeat()
    {

        // Host and client 
        GameObject host = new GameObject("Host");
        float client = 0;

        // Keyframes for the animation
        var keyframes = new Dictionary<int, float>
        {
            {0, client},
            {50, 3f},
            {100, 20f},
        };

        // Function to set the value to the client
        void Animate(float x)
        {
            Debug.Log(x);
            client = x;
        }

        // Animation Params
        var animationParams = new TimeAnimationParams
        {
            // Set        // Default
            delay = 2, // delay = 0,
            //direction = Utween.Direction.Normal,
            //duration = 2,
            //fillMode = Utween.FillMode.Both,
            iterations = 4,  //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Create the animation
        var tween = Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // Because of the delay the animation will not start inmediatly
        yield return new WaitForSecondsRealtime(1.9f);
        Assert.AreEqual(0f, client);

        // The animation will start
        yield return new WaitForSecondsRealtime(7.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(1f);
        Assert.AreEqual(20f, client);


        // Animation can be reset
        tween.Repeat();
        client = 0;

        // Because of the delay the animation will not start inmediatly
        yield return new WaitForSecondsRealtime(1.9f);
        Assert.AreEqual(0f, client);

        // The animation will start
        yield return new WaitForSecondsRealtime(7.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(1f);
        Assert.AreEqual(20f, client);

    }





    [UnityTest]
    public IEnumerator TweenFloat_CheckIterationsAndDirectionReverse()
    {

        // Host and client 
        GameObject host = new GameObject("Host");
        float client = 0;

        // Keyframes for the animation
        var keyframes = new Dictionary<int, float>
        {
            {0, client},
            {50, 3f},
            {100, 20f},
        };

        // Function to set the value to the client
        void Animate(float x)
        {
            Debug.Log(x);
            client = x;
        }

        // Animation Params
        var animationParams = new TimeAnimationParams
        {
            // Set        // Default
            // delay = 3, // delay = 0,
            direction = Utween.Direction.Reverse,  //direction = Utween.Direction.Normal,
            //duration = 2,
            //fillMode = Utween.FillMode.Both,
            iterations = 4,  //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Create the animation
        Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(7.9f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(1f);
        Assert.AreEqual(0f, client);


    }



    [UnityTest]
    public IEnumerator TweenFloat_CheckIterationsAndDirectionAlternate()
    {

        // Host and client 
        GameObject host = new GameObject("Host");
        float client = 0;

        // Keyframes for the animation
        var keyframes = new Dictionary<int, float>
        {
            {0, client},
            {50, 3f},
            {100, 20f},
        };

        // Function to set the value to the client
        void Animate(float x)
        {
            Debug.Log(x);
            client = x;
        }

        // Animation Params
        var animationParams = new TimeAnimationParams
        {
            // Set        // Default
            // delay = 3, // delay = 0,
            direction = Utween.Direction.Alternate,  //direction = Utween.Direction.Normal,
            //duration = 2,
            //fillMode = Utween.FillMode.Both,
            iterations = 4,  //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Create the animation
        Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(7.9f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(1f);
        Assert.AreEqual(0f, client);


    }



    [UnityTest]
    public IEnumerator TweenFloat_CheckIterationsAndDirectionAlternateReverse()
    {

        // Host and client 
        GameObject host = new GameObject("Host");
        float client = 0;

        // Keyframes for the animation
        var keyframes = new Dictionary<int, float>
        {
            {0, client},
            {50, 3f},
            {100, 20f},
        };

        // Function to set the value to the client
        void Animate(float x)
        {
            Debug.Log(x);
            client = x;
        }

        // Animation Params
        var animationParams = new TimeAnimationParams
        {
            // Set        // Default
            // delay = 3, // delay = 0,
            direction = Utween.Direction.AlternateReverse,  //direction = Utween.Direction.Normal,
            //duration = 2,
            //fillMode = Utween.FillMode.Both,
            iterations = 4,  //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Create the animation
        Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(7.9f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(1f);
        Assert.AreEqual(20f, client);


    }

}
