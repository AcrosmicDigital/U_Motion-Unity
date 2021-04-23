using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using U.Motion;
using UnityEngine;
using UnityEngine.TestTools;

public class Utween_TweenFloat_Exceptions
{



    class Amono : MonoBehaviour { }




    [UnityTest]
    public IEnumerator TweenFloat_WhenAnimateFunctionThrowError()
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
            throw new System.Exception("Expected exception");
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

        // Expect a log message
        LogAssert.Expect(LogType.Exception, "Exception: Expected exception");

        // Create the animation
        var animation = Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        yield return new WaitForSecondsRealtime(.1f);
        Assert.IsTrue(animation.IsCompleted);
        Assert.NotNull(animation.Error);
        Assert.IsFalse(animation.enabled);

    }





    [UnityTest]
    public IEnumerator TweenFloat_WhenAnimatorComponentIsDestroyed()
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

        // Expect a log message
        LogAssert.ignoreFailingMessages = true;

        // Create the animation
        var animation = Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        yield return new WaitForSecondsRealtime(.1f);
        Object.DestroyImmediate(animation);


        //Assert.IsTrue(animation.IsCompleted);
        //Assert.NotNull(animation.Error);
        Assert.IsTrue(animation == null);

    }



    [UnityTest]
    public IEnumerator TweenFloat_TaskError()
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
            throw new System.Exception("Expected Exception");
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
            Debug.Log("Running animation with error");
            await Utween.AnimateFloat(host, Animate, keyframes, animationParams).Task();
            Debug.Log("Running animation with error");
            await Utween.AnimateFloat(host, Animate2, keyframes, animationParams).Task();

            await Utween.AnimateFloat(host, Animate3, keyframes, animationParams).Task();
        }


        // Expect a log message, one from the Task and one is the log from the AnimatorCore
        LogAssert.ignoreFailingMessages = true;

        // Run the animations
        Sequence();

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(1f);
        Assert.AreEqual(0f, client);
        Assert.AreEqual(0f, client2);
        Assert.AreEqual(0f, client3);


    }



    [UnityTest]
    public IEnumerator TweenFloat_CorroutineError()
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
            throw new System.Exception("Expected Exception");
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
        IEnumerator Sequence()
        {
            Debug.Log("Running animation with error");
            yield return Utween.AnimateFloat(host, Animate, keyframes, animationParams).Coroutine();
            Debug.Log("Running animation with error");

            yield return Utween.AnimateFloat(host, Animate2, keyframes, animationParams).Task();

            yield return Utween.AnimateFloat(host, Animate3, keyframes, animationParams).Task();
        }


        // Expect a log message, one from the Task and one is the log from the AnimatorCore
        LogAssert.ignoreFailingMessages = true;

        // Run the animations
        host.AddComponent<Amono>().StartCoroutine(Sequence());

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(1f);
        Assert.AreEqual(0f, client);
        Assert.AreEqual(0f, client2);
        Assert.AreEqual(0f, client3);


    }




    [UnityTest]
    public IEnumerator TweenFloat_TaskErrorWhenAnimatorComponentIsDestroyed()
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
            throw new System.Exception("Expected Exception");
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



        var animator = Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // A Function to create the animations
        async void Sequence()
        {
            Debug.Log("Running animation with error");
            await animator.Task();
            Debug.Log("Running animation with error");

            await Utween.AnimateFloat(host, Animate2, keyframes, animationParams).Task();

            await Utween.AnimateFloat(host, Animate3, keyframes, animationParams).Task();
        }


        // Expect a log message, one from the Task and one is the log from the AnimatorCore
        LogAssert.ignoreFailingMessages = true;

        // Run the animations
        Sequence();
        Object.Destroy(animator);

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(5f);
        Assert.AreEqual(0f, client2);
        Assert.AreEqual(0f, client3);


    }



    [UnityTest]
    public IEnumerator TweenFloat_CorroutineErrorWhenAnimatorComponentIsDestroyed()
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


        var animator = Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // A Function to create the animations
        IEnumerator Sequence()
        {
            Debug.Log("Running animation with error");
            yield return animator.Coroutine();

            Debug.Log("Running animation with error");

            yield return Utween.AnimateFloat(host, Animate2, keyframes, animationParams).Task();

            yield return Utween.AnimateFloat(host, Animate3, keyframes, animationParams).Task();
        }


        // Expect a log message, one from the Task and one is the log from the AnimatorCore
        LogAssert.ignoreFailingMessages = true;

        // Run the animations
        host.AddComponent<Amono>().StartCoroutine(Sequence());
        Object.Destroy(animator);

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(5f);
        Assert.AreEqual(0f, client2);
        Assert.AreEqual(0f, client3);


    }


}
