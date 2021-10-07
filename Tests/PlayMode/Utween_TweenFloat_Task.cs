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
        float client = 0;
        float client2 = 0;
        float client3 = 0;

        // A Function to create the animations
        async void Sequence()
        {
            await TweenAnimator.TweenFloat.AddComponent(new GameObject("Host"), new TweenAnimator.TweenFloat.Properties
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
            }).Task();

            await TweenAnimator.TweenFloat.AddComponent(new GameObject("Host"), new TweenAnimator.TweenFloat.Properties
            {
                animate = (x) =>
                {
                    Debug.Log(x);
                    client2 = x;
                },
                keyframes = new TweenAnimator.TweenFloat.Keyframe[]
                {
                    new TweenAnimator.TweenFloat.Keyframe {key = 0, value = client},
                    new TweenAnimator.TweenFloat.Keyframe {key = 50, value = 3f},
                    new TweenAnimator.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            }).Task();

            await TweenAnimator.TweenFloat.AddComponent(new GameObject("Host"), new TweenAnimator.TweenFloat.Properties
            {
                animate = (x) =>
                {
                    Debug.Log(x);
                    client3 = x;
                },
                keyframes = new TweenAnimator.TweenFloat.Keyframe[]
                {
                    new TweenAnimator.TweenFloat.Keyframe {key = 0, value = client},
                    new TweenAnimator.TweenFloat.Keyframe {key = 50, value = 3f},
                    new TweenAnimator.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            }).Task();
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
        float client = 0;



        // A Function to create the animations
        async void Sequence()
        {
            var animation = TweenAnimator.TweenFloat.AddComponent(new GameObject("Host"), new TweenAnimator.TweenFloat.Properties
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
            });

            await animation.Task();

            client = 0;

            await Task.Delay(2000);

            animation.Restart();

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
