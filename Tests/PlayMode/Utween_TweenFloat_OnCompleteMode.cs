using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using U.Motion;
using UnityEngine;
using UnityEngine.TestTools;

public class Utween_TweenFloat_OnCompleteMode
{


    [UnityTest]
    public IEnumerator TweenFloat_CheckOnCompleteModeDisable()
    {

        // Host and client 
        float client = 0;

        // Create the animation
        var animation = Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
        {
            onCompleteMode = Utween.OnCompleteMode.Disable,
            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new Uanimators.TweenFloat.Keyframe[]
            {
                new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
            },
        });

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);


        // Check if is disabled
        Assert.IsFalse(animation.enabled);

    }


    [UnityTest]
    public IEnumerator TweenFloat_CheckOnCompleteModeDisableCompleteNow()
    {

        // Host and client 
        float client = 0;

        // Create the animation
        var animation = Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
        {

            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new Uanimators.TweenFloat.Keyframe[]
            {
                new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
            },
        });

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        animation.CompleteNow();


        // Check if is disabled
        Assert.IsFalse(animation.enabled);

    }





    [UnityTest]
    public IEnumerator TweenFloat_CheckOnCompleteModeDestroy()
    {

        // Host and client 
        float client = 0;

        // Create the animation
        var animation = Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
        {

            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new Uanimators.TweenFloat.Keyframe[]
            {
                new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            onCompleteMode = Utween.OnCompleteMode.Destroy,
        });

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);


        // Check if is disabled
        Assert.IsTrue(animation == null);

    }


    [UnityTest]
    public IEnumerator TweenFloat_CheckOnCompleteModeDestroyCompleteNow()
    {

        // Host and client 
        float client = 0;

        // Create the animation
        var animation = Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
        {

            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new Uanimators.TweenFloat.Keyframe[]
            {
                new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            onCompleteMode = Utween.OnCompleteMode.Destroy,
        });

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        animation.CompleteNow();
        yield return new WaitForSecondsRealtime(.1f);

        // Check if is disabled
        Assert.IsTrue(animation == null);

    }





    [UnityTest]
    public IEnumerator TweenFloat_CheckOnCompleteModeLoop()
    {

        // Host and client 
        float client = 0;

        // Create the animation
        var animation = Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
        {

            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new Uanimators.TweenFloat.Keyframe[]
            {
                new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            onCompleteMode = Utween.OnCompleteMode.Loop,
        });

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(11f);
        Assert.IsTrue(client > 0 && client < 20);

    }


    [UnityTest]
    public IEnumerator TweenFloat_CheckOnCompleteModeLoopCompleteNow()
    {

        // Host and client 
        float client = 0;

        // Create the animation
        var animation = Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
        {

            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new Uanimators.TweenFloat.Keyframe[]
            {
                new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            onCompleteMode = Utween.OnCompleteMode.Loop,
        });

        yield return new WaitForSecondsRealtime(1f);
        animation.CompleteNow();

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(10f);
        Assert.IsTrue(client > 0 && client < 20);


    }





    [UnityTest]
    public IEnumerator TweenFloat_CheckOnCompleteModeNone()
    {

        // Host and client 
        float client = 0;

        // Create the animation
        var animation = Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
        {

            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new Uanimators.TweenFloat.Keyframe[]
            {
                new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            onCompleteMode = Utween.OnCompleteMode.None,
        });

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);


        // Check if is disabled
        Assert.IsTrue(animation.enabled);

    }


    [UnityTest]
    public IEnumerator TweenFloat_CheckOnCompleteModeNoneCompleteNow()
    {

        // Host and client 
        float client = 0;

        // Create the animation
        var animation = Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
        {

            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new Uanimators.TweenFloat.Keyframe[]
            {
                new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            onCompleteMode = Utween.OnCompleteMode.None,
        });

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        animation.CompleteNow();


        // Check if is disabled
        Assert.IsTrue(animation.enabled);

    }




}
