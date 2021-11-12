using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using U.Motion;

public class Tweens_TweenFloat_Delay
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
        float client = 0;

        Uanimation.TweenFloat.AddComponent(new GameObject("Host"), new Uanimation.TweenFloat.Properties 
        {
            
            animate = (x) => 
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new Uanimation.TweenFloat.Keyframe[]
            {
                new Uanimation.TweenFloat.Keyframe {key = 0, value = client},
                new Uanimation.TweenFloat.Keyframe {key = 50, value = 3f},
                new Uanimation.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            delay = 3,
        });

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
        float client = 0;

        Uanimation.TweenFloat.AddComponent(new GameObject("Host"), new Uanimation.TweenFloat.Properties
        {
            
            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new Uanimation.TweenFloat.Keyframe[]
            {
                new Uanimation.TweenFloat.Keyframe {key = 0, value = client},
                new Uanimation.TweenFloat.Keyframe {key = 50, value = 3f},
                new Uanimation.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            delay = 10,
        });

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
        float client = 0;

        Uanimation.TweenFloat.AddComponent(new GameObject("Host"), new Uanimation.TweenFloat.Properties
        {
            
            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new Uanimation.TweenFloat.Keyframe[]
            {
                new Uanimation.TweenFloat.Keyframe {key = 0, value = client},
                new Uanimation.TweenFloat.Keyframe {key = 50, value = 3f},
                new Uanimation.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            delay = 10,
            duration = 5,
        });

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
        float client = 0;

        // Pause the game
        Time.timeScale = 0;


        Uanimation.TweenFloat.AddComponent(new GameObject("Host"), new Uanimation.TweenFloat.Properties
        {
            timeMode = Uanimation.TimeMode.UnscaledDeltaTime,
            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new Uanimation.TweenFloat.Keyframe[]
            {
                new Uanimation.TweenFloat.Keyframe {key = 0, value = client},
                new Uanimation.TweenFloat.Keyframe {key = 50, value = 3f},
                new Uanimation.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            delay = 10,
            duration = 5,
        });

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
        float client = 0;

        // Pause the game
        Time.timeScale = .5f;

        // Create the animation
        Uanimation.TweenFloat.AddComponent(new GameObject("Host"), new Uanimation.TweenFloat.Properties
        {
            
            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new Uanimation.TweenFloat.Keyframe[]
            {
                new Uanimation.TweenFloat.Keyframe {key = 0, value = client},
                new Uanimation.TweenFloat.Keyframe {key = 50, value = 3f},
                new Uanimation.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            delay = 2,
            duration = 5,
            timeMode = Uanimation.TimeMode.DeltaTime,
        });

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
        float client = 0;


        // Set the framerate
        Application.targetFrameRate = 5;


        Uanimation.TweenFloat.AddComponent(new GameObject("Host"), new Uanimation.TweenFloat.Properties
        {
            
            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new Uanimation.TweenFloat.Keyframe[]
            {
                new Uanimation.TweenFloat.Keyframe {key = 0, value = client},
                new Uanimation.TweenFloat.Keyframe {key = 50, value = 3f},
                new Uanimation.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            delay = 1.1f,
            duration = 1,
        });

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
        float client = 0;

        // Set the framerate .. Lower than 3, will fail, because Time.deltaTime cant be more than .333 and a lower framerate will produce more that .333 but are not displayed becouse of Unity
        Application.targetFrameRate = 3;

        Uanimation.TweenFloat.AddComponent(new GameObject("Host"), new Uanimation.TweenFloat.Properties
        {
            
            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new Uanimation.TweenFloat.Keyframe[]
            {
                new Uanimation.TweenFloat.Keyframe {key = 0, value = client},
                new Uanimation.TweenFloat.Keyframe {key = 50, value = 3f},
                new Uanimation.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            delay = 1,
            duration = 5,
            timeMode = Uanimation.TimeMode.DeltaTime,
        });

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
        float client = 0;

        var tween = Uanimation.TweenFloat.AddComponent(new GameObject("Host"), new Uanimation.TweenFloat.Properties
        {
            
            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new Uanimation.TweenFloat.Keyframe[]
            {
                new Uanimation.TweenFloat.Keyframe {key = 0, value = client},
                new Uanimation.TweenFloat.Keyframe {key = 50, value = 3f},
                new Uanimation.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            delay = 2,
        });

        // Pause the animation
        tween.Pause();
        yield return new WaitForSecondsRealtime(3f);
        tween.Restart();

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
        float client = 0;


        // Create the animation
        var tween = Uanimation.TweenFloat.AddComponent(new GameObject("Host"), new Uanimation.TweenFloat.Properties
        {
            onCompleteMode = Uanimation.OnCompleteMode.Disable,
            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new Uanimation.TweenFloat.Keyframe[]
            {
                new Uanimation.TweenFloat.Keyframe {key = 0, value = client},
                new Uanimation.TweenFloat.Keyframe {key = 50, value = 3f},
                new Uanimation.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            delay = 2,
        });

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
        tween.Restart();
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
