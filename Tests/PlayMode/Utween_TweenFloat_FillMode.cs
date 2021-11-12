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
            fillMode = Utween.FillMode.Backwards,
        });

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
            fillMode = Utween.FillMode.Forwards,
        });

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
            fillMode = Utween.FillMode.None,
        });

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

        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

    }




    [UnityTest]
    public IEnumerator TweenFloat_CheckFillModeBackwardsOnCompleteNow()
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
            fillMode = Utween.FillMode.Backwards,
        });

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
            fillMode = Utween.FillMode.Forwards,
        });

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
            fillMode = Utween.FillMode.None,
        });

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
            fillMode = Utween.FillMode.Backwards,
        });

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(0f, client);

        animation.Restart();

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(.5f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(0f, client);

    }






}
