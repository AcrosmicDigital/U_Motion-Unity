using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using U.Motion;
using UnityEngine;
using UnityEngine.TestTools;

public class Utween_TweenFloat_FillMode
{


    [UnityTest]
    public IEnumerator TweenFloat_CheckFillModeBackwards()
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
            // delay = 0,
            //direction = Utween.Direction.Normal,
            //duration = 2,
            fillMode = Utween.FillMode.Backwards,  //fillMode = Utween.FillMode.Both,
            //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Create the animation
        Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(0f, client);

    }



    [UnityTest]
    public IEnumerator TweenFloat_CheckFillModeForwards()
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
            // delay = 0,
            //direction = Utween.Direction.Normal,
            //duration = 2,
            fillMode = Utween.FillMode.Forwards,  //fillMode = Utween.FillMode.Both,
            //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Create the animation
        Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);

    }




    [UnityTest]
    public IEnumerator TweenFloat_CheckFillModeNone()
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
            // delay = 0,
            //direction = Utween.Direction.Normal,
            //duration = 2,
            fillMode = Utween.FillMode.None,  //fillMode = Utween.FillMode.Both,
            //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Create the animation
        Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.AreEqual(0f, client);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(0f, client);

    }




    [UnityTest]
    public IEnumerator TweenFloat_CheckFillModeBothOnCompleteNow()
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
            // delay = 0,
            //direction = Utween.Direction.Normal,
            //duration = 2,
            //fillMode = Utween.FillMode.Both,
            //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Create the animation
        var animation = Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        animation.CompleteNow();

        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

    }




    [UnityTest]
    public IEnumerator TweenFloat_CheckFillModeBackwardsOnCompleteNow()
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
            // delay = 0,
            //direction = Utween.Direction.Normal,
            //duration = 2,
            fillMode = Utween.FillMode.Backwards,  //fillMode = Utween.FillMode.Both,
            //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Create the animation
        var animation = Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        animation.CompleteNow();
        yield return new WaitForSecondsRealtime(.5f);
        Assert.AreEqual(0f, client);

    }



    [UnityTest]
    public IEnumerator TweenFloat_CheckFillModeForwardsOnCompleteNow()
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
            // delay = 0,
            //direction = Utween.Direction.Normal,
            //duration = 2,
            fillMode = Utween.FillMode.Forwards,  //fillMode = Utween.FillMode.Both,
            //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Create the animation
        var animation = Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        animation.CompleteNow();
        yield return new WaitForSecondsRealtime(.5f);
        Assert.AreEqual(20f, client);

    }




    [UnityTest]
    public IEnumerator TweenFloat_CheckFillModeNoneOnCompleteNow()
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
            // delay = 0,
            //direction = Utween.Direction.Normal,
            //duration = 2,
            fillMode = Utween.FillMode.None,  //fillMode = Utween.FillMode.Both,
            //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Create the animation
        var animation = Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.AreEqual(0f, client);

        // And end
        yield return new WaitForSecondsRealtime(.5f);
        animation.CompleteNow();
        Assert.AreEqual(0f, client);

    }



    [UnityTest]
    public IEnumerator TweenFloat_CheckFillModeBackwardsRepeat()
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
            // delay = 0,
            //direction = Utween.Direction.Normal,
            //duration = 2,
            fillMode = Utween.FillMode.Backwards,  //fillMode = Utween.FillMode.Both,
            //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Create the animation
        var animation = Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(0f, client);

        animation.Repeat();

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(0f, client);

    }






}
