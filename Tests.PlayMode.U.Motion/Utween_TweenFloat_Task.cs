using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using U.Motion;
using UnityEngine;
using UnityEngine.TestTools;

public class Utween_TweenFloat_Task
{


    [UnityTest]
    public IEnumerator TweenFloat_Task()
    {

        // Host and client 
        GameObject host = new GameObject("Host");
        float client = 0;
        float client2 = 0;
        float client3 = 0;

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
        void Animate2(float x)
        {
            Debug.Log(x);
            client2 = x;
        }
        void Animate3(float x)
        {
            Debug.Log(x);
            client3 = x;
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


        // A Function to create the animations
        async void Sequence()
        {
            await Utween.AnimateFloat(host, Animate, keyframes, animationParams).Task();

            await Utween.AnimateFloat(host, Animate2, keyframes, animationParams).Task();

            await Utween.AnimateFloat(host, Animate3, keyframes, animationParams).Task();
        }


        // Run the animations
        Sequence();

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(1f);
        Assert.IsTrue(client > 0 && client < 20);
        Assert.AreEqual(0f, client2);
        Assert.AreEqual(0f, client3);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);
        Assert.IsTrue(client2 > 0 && client2 < 20);
        Assert.AreEqual(0f, client3);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);
        Assert.AreEqual(20f, client2);
        Assert.IsTrue(client3 > 0 && client3 < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);
        Assert.AreEqual(20f, client2);
        Assert.AreEqual(20f, client3);


    }



    [UnityTest]
    public IEnumerator TweenFloat_TaskAndRepeat()
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


        // A Function to create the animations
        async void Sequence()
        {
            var animation = Utween.AnimateFloat(host, Animate, keyframes, animationParams);

            await animation.Task();

            client = 0;

            await Task.Delay(2000);

            animation.Repeat();

            await animation.Task();

            Debug.LogAssertion("Finalizado");

        }


        // Run the animations
        Sequence();

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(1f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(0f, client);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.IsTrue(client > 0 && client < 20);
        LogAssert.Expect(LogType.Assert, "Finalizado");

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);


    }



}
