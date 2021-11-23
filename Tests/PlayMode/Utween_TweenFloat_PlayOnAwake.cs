using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using U.Motion;

public class Utween_TweenFloat_PlayOnAwake
{
    [UnityTest]
    public IEnumerator TweenFloat_CheckDelay()
    {

        // Host and client 
        float client = 0;

        // Create the animation
        var anim = UAnimation.TweenFloat.AddComponent(new GameObject("Host"), new UAnimation.TweenFloat.Properties
        {

            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
            },
            keyframes = new UAnimation.TweenFloat.Keyframe[]
            {
                new UAnimation.TweenFloat.Keyframe {key = 0, value = client},
                new UAnimation.TweenFloat.Keyframe {key = 50, value = 3f},
                new UAnimation.TweenFloat.Keyframe {key = 100, value = 20f},
            },
            playOnAwake = false,
        });

        // Because wont playOnAwakr the animation will not start inmediatly
        yield return new WaitForSecondsRealtime(3f);
        Assert.AreEqual(0f, client);

        // Play The animation
        anim.Play();

        // The animation will start
        yield return new WaitForSecondsRealtime(1.2f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);

    }

}
