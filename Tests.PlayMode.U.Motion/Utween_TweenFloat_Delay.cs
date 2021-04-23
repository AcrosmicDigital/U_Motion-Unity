using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using U.Motion;

public class Utween_TweenFloat_Delay
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
    public IEnumerator TweenFloat_CheckDelay()
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
            delay = 3, // delay = 0,
            //direction = Utween.Direction.Normal,
            //duration = 2,
            //fillMode = Utween.FillMode.Both,
            //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Create the animation
        Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // Because of the delay the animation will not start inmediatly
        yield return new WaitForSecondsRealtime(2.9f);
        Assert.AreEqual(0f, client);

        // The animation will start
        yield return new WaitForSecondsRealtime(1f);
        Assert.IsTrue(client > 0  &&  client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);

    }

    [UnityTest]
    public IEnumerator TweenFloat_BCheckDelay()
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
            delay = 10, // delay = 0,
            //direction = Utween.Direction.Normal,
            //duration = 2,
            //fillMode = Utween.FillMode.Both,
            //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Create the animation
        Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // Because of the delay the animation will not start inmediatly
        yield return new WaitForSecondsRealtime(9.9f);
        Assert.AreEqual(0f, client);

        // The animation will start
        yield return new WaitForSecondsRealtime(1f);
        Assert.IsTrue(client > 0  &&  client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);

    }



    [UnityTest]
    public IEnumerator TweenFloat_CCheckDelayAndDuration()
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
            delay = 10, // delay = 0,
            //direction = Utween.Direction.Normal,
            duration = 5, //duration = 2,
            //fillMode = Utween.FillMode.Both,
            //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Create the animation
        Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // Because of the delay the animation will not start inmediatly
        yield return new WaitForSecondsRealtime(9.9f);
        Assert.AreEqual(0f, client);

        // The animation will start
        yield return new WaitForSecondsRealtime(1f);
        Assert.IsTrue(client > 0  &&  client < 20);

        // And end
        yield return new WaitForSecondsRealtime(5f);
        Assert.AreEqual(20f, client);

    }



    [UnityTest]
    public IEnumerator TweenFloat_DCheckDelayAndDurationAndTimeModeUnscaledDelta()
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
            delay = 10, // delay = 0,
            //direction = Utween.Direction.Normal,
            duration = 5, //duration = 2,
            //fillMode = Utween.FillMode.Both,
            //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Pause the game
        Time.timeScale = 0;

        // Create the animation
        Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // Because of the delay the animation will not start inmediatly
        yield return new WaitForSecondsRealtime(9.9f);
        Assert.AreEqual(0f, client);

        // The animation will start
        yield return new WaitForSecondsRealtime(1f);
        Assert.IsTrue(client > 0  &&  client < 20);

        // And end
        yield return new WaitForSecondsRealtime(5f);
        Assert.AreEqual(20f, client);

    }


    [UnityTest]
    public IEnumerator TweenFloat_ECheckDelayAndDurationAndTimeModeDelta()
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
            duration = 5, //duration = 2,
            //fillMode = Utween.FillMode.Both,
            //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            timeMode = Utween.TimeMode.DeltaTime,  //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Pause the game
        Time.timeScale = .5f;

        // Create the animation
        Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // Because of the delay the animation will not start inmediatly
        yield return new WaitForSecondsRealtime(3.9f);
        Assert.AreEqual(0f, client);

        // The animation will start
        yield return new WaitForSecondsRealtime(1f);
        Assert.IsTrue(client > 0  &&  client < 20);

        // And end
        yield return new WaitForSecondsRealtime(10f);
        Assert.AreEqual(20f, client);

    }


    [UnityTest]
    public IEnumerator TweenFloat_FCheckDelayAndDurationAndTimeModeUnscaledDeltaLowFrameRate()
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
            Debug.Log(x + "  " + Time.unscaledDeltaTime);
            client = x;
        }

        // Animation Params
        var animationParams = new TimeAnimationParams
        {
            // Set        // Default
            delay = 1.1f, // delay = 0,
            //direction = Utween.Direction.Normal,
            duration = 1, //duration = 2,
            //fillMode = Utween.FillMode.Both,
            //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Set the framerate
        Application.targetFrameRate = 5;

        // Create the animation
        Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // Because of the delay the animation will not start inmediatly
        yield return new WaitForSecondsRealtime(.9f);
        Assert.AreEqual(0f, client);

        // The animation will start
        yield return new WaitForSecondsRealtime(1f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(5f);
        Assert.AreEqual(20f, client);

    }


    [UnityTest]
    public IEnumerator TweenFloat_GCheckDelayAndDurationAndTimeModeDeltaLowFrameRate()
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
            Debug.Log(x + "   " + Time.deltaTime);
            client = x;
        }

        // Animation Params
        var animationParams = new TimeAnimationParams
        {
            // Set        // Default
            delay = 1, // delay = 0,
            //direction = Utween.Direction.Normal,
            duration = 5, //duration = 2,
            //fillMode = Utween.FillMode.Both,
            //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            timeMode = Utween.TimeMode.DeltaTime,  //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Set the framerate .. Lower than 3, will fail, because Time.deltaTime cant be more than .333 and a lower framerate will produce more that .333 but are not displayed becouse of Unity
        Application.targetFrameRate = 3;

        // Create the animation
        Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // Because of the delay the animation will not start inmediatly
        yield return new WaitForSecondsRealtime(.9f);
        Assert.AreEqual(0f, client);

        // The animation will start
        yield return new WaitForSecondsRealtime(1f);
        //Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(5f);
        Assert.AreEqual(20f, client);


    }


    [UnityTest]
    public IEnumerator TweenFloat_HCheckDelayAndPause()
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
            //iterations = 1,
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
        yield return new WaitForSecondsRealtime(1f);
        Assert.IsTrue(client > 0  &&  client < 20);

        // And end
        yield return new WaitForSecondsRealtime(5f);
        Assert.AreEqual(20f, client);

    }



    [UnityTest]
    public IEnumerator TweenFloat_ICheckDelayAndRepeat()
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
            //iterations = 1,
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
        yield return new WaitForSecondsRealtime(1f);
        Assert.IsTrue(client > 0  &&  client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);


        // Animation can be reset
        tween.Repeat();
        client = 0;

        // Because of the delay the animation will not start inmediatly
        yield return new WaitForSecondsRealtime(1.9f);
        Assert.AreEqual(0f, client);

        // The animation will start
        yield return new WaitForSecondsRealtime(1f);
        Assert.IsTrue(client > 0  &&  client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);

    }



}
