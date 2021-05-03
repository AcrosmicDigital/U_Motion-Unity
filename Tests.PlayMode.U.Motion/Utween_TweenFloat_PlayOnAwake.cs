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
            playOnAwake = false,  // Default true
            //direction = Utween.Direction.Normal,
            //duration = 2,
            //fillMode = Utween.FillMode.Both,
            //iterations = 1,
            //onCompleteMode = Utween.OnCompleteMode.Disable,
            //timeMode = Utween.TimeMode.UnscaledDeltaTime,
            //timingCurve = TimeCurve.easeInOut,
        };

        // Create the animation
        var anim = Utween.AnimateFloat(host, Animate, keyframes, animationParams);

        // Because wont playOnAwakr the animation will not start inmediatly
        yield return new WaitForSecondsRealtime(3f);
        Assert.AreEqual(0f, client);

        // Play The animation
        anim.Resume();

        // The animation will start
        yield return new WaitForSecondsRealtime(1.2f);
        Assert.IsTrue(client > 0 && client < 20);

        // And end
        yield return new WaitForSecondsRealtime(2f);
        Assert.AreEqual(20f, client);

    }

}
