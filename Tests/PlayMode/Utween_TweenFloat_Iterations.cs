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
        float client = 0;

        TweenAnimator.TweenFloat.AddComponent(new GameObject("Host"), new TweenAnimator.TweenFloat.Properties
        {
            
            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new TweenAnimator.TweenFloat.Keyframe[]
            {
                new TweenAnimator.TweenFloat.Keyframe {key = 0, value = client},
                new TweenAnimator.TweenFloat.Keyframe {key = 50, value = 3f},
                new TweenAnimator.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            iterations = 4,
        });

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
        float client = 0;

        // Create the animation
        TweenAnimator.TweenFloat.AddComponent(new GameObject("Host"), new TweenAnimator.TweenFloat.Properties
        {
            
            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new TweenAnimator.TweenFloat.Keyframe[]
            {
                new TweenAnimator.TweenFloat.Keyframe {key = 0, value = client},
                new TweenAnimator.TweenFloat.Keyframe {key = 50, value = 3f},
                new TweenAnimator.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            iterations = 4,
            delay = 2,
        });

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
        float client = 0;

        // Create the animation
        var tween = TweenAnimator.TweenFloat.AddComponent(new GameObject("Host"), new TweenAnimator.TweenFloat.Properties
        {
            
            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new TweenAnimator.TweenFloat.Keyframe[]
            {
                new TweenAnimator.TweenFloat.Keyframe {key = 0, value = client},
                new TweenAnimator.TweenFloat.Keyframe {key = 50, value = 3f},
                new TweenAnimator.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            delay = 2,
            iterations = 4,
        });

        // Pause the animation
        Debug.Log("Pause");
        tween.Pause();
        yield return new WaitForSecondsRealtime(3f);
        Debug.Log("Play");
        tween.Play();

        // Because of the delay the animation will not start inmediatly
        yield return new WaitForSecondsRealtime(1.9f);
        Debug.Log("EndDelay");
        Assert.AreEqual(0f, client);

        // The animation will start
        yield return new WaitForSecondsRealtime(7.5f);
        Debug.Log("EndAnimation");
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);

    }



    [UnityTest]
    public IEnumerator TweenFloat_DCheckIterationsAndRepeat()
    {

        // Host and client 
        float client = 0;

        // Create the animation
        var tween = TweenAnimator.TweenFloat.AddComponent(new GameObject("Host"), new TweenAnimator.TweenFloat.Properties
        {
            
            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new TweenAnimator.TweenFloat.Keyframe[]
            {
                new TweenAnimator.TweenFloat.Keyframe {key = 0, value = client},
                new TweenAnimator.TweenFloat.Keyframe {key = 50, value = 3f},
                new TweenAnimator.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            iterations = 4,
            delay = 2,
        });

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
        tween.Restart();
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
        float client = 0;

        // Create the animation
        TweenAnimator.TweenFloat.AddComponent(new GameObject("Host"), new TweenAnimator.TweenFloat.Properties
        {
            
            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new TweenAnimator.TweenFloat.Keyframe[]
            {
                new TweenAnimator.TweenFloat.Keyframe {key = 0, value = client},
                new TweenAnimator.TweenFloat.Keyframe {key = 50, value = 3f},
                new TweenAnimator.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            iterations = 4,
            direction = Utween.Direction.Reverse,
        });

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
        float client = 0;

        // Create the animation
        TweenAnimator.TweenFloat.AddComponent(new GameObject("Host"), new TweenAnimator.TweenFloat.Properties
        {
            
            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new TweenAnimator.TweenFloat.Keyframe[]
            {
                new TweenAnimator.TweenFloat.Keyframe {key = 0, value = client},
                new TweenAnimator.TweenFloat.Keyframe {key = 50, value = 3f},
                new TweenAnimator.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            iterations = 4,
            direction = Utween.Direction.Alternate,
        });

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
        float client = 0;


        // Create the animation
        TweenAnimator.TweenFloat.AddComponent(new GameObject("Host"), new TweenAnimator.TweenFloat.Properties
        {
            
            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new TweenAnimator.TweenFloat.Keyframe[]
            {
                new TweenAnimator.TweenFloat.Keyframe {key = 0, value = client},
                new TweenAnimator.TweenFloat.Keyframe {key = 50, value = 3f},
                new TweenAnimator.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            iterations = 4,
            direction = Utween.Direction.AlternateReverse,
        });

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(7.9f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(1f);
        Assert.AreEqual(20f, client);


    }

}
