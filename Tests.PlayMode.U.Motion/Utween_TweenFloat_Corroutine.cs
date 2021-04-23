using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using U.Motion;
using UnityEngine;
using UnityEngine.TestTools;

public class Utween_TweenFloat_Corroutine
{


    class Amono : MonoBehaviour { }



    [UnityTest]
    public IEnumerator TweenFloat_Coroutine()
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



        IEnumerator Sequence()
        {
            yield return Utween.AnimateFloat(host, Animate, keyframes, animationParams).Coroutine();

            yield return Utween.AnimateFloat(host, Animate2, keyframes, animationParams).Coroutine();

            yield return Utween.AnimateFloat(host, Animate3, keyframes, animationParams).Coroutine();
        }


        // Run the animations
        host.AddComponent<Amono>().StartCoroutine(Sequence());


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
    public IEnumerator TweenFloat_CoroutineAndRepeat()
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
        IEnumerator Sequence()
        {
            var animation = Utween.AnimateFloat(host, Animate, keyframes, animationParams);

            yield return animation.Coroutine();

            client = 0;

            yield return new WaitForSecondsRealtime(2);

            animation.Repeat();

            yield return animation.Coroutine();

            Debug.LogAssertion("Finalizado");
        }



        // Run the animations
        host.AddComponent<Amono>().StartCoroutine(Sequence());



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
