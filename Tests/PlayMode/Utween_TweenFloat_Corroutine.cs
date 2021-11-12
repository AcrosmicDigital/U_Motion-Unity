using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using U.Motion;
using UnityEngine;
using UnityEngine.TestTools;

public class Tweens_TweenFloat_Corroutine
{

    GameObject _host;

    [SetUp]
    public void SetUo()
    {
        Object.DestroyImmediate(_host);
        _host = new GameObject("Host");
    }



    class Amono : MonoBehaviour { }



    [UnityTest]
    public IEnumerator TweenFloat_Coroutine()
    {

        // Host and client 
        float client = 0;
        float client2 = 0;
        float client3 = 0;


        IEnumerator Sequence()
        {
            yield return Uanimation.TweenFloat.AddComponent(_host, new Uanimation.TweenFloat.Properties
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
            }).Coroutine();

            yield return Uanimation.TweenFloat.AddComponent(_host, new Uanimation.TweenFloat.Properties
            {
                animate = (x) =>
                {
                    Debug.Log(x);
                    client2 = x;
                },
                keyframes = new Uanimation.TweenFloat.Keyframe[]
                {
                    new Uanimation.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimation.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimation.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            }).Coroutine();

            yield return Uanimation.TweenFloat.AddComponent(_host, new Uanimation.TweenFloat.Properties
            {
                animate = (x) =>
                {
                    Debug.Log(x);
                    client3 = x;
                },
                keyframes = new Uanimation.TweenFloat.Keyframe[]
                {
                    new Uanimation.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimation.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimation.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            }).Coroutine();
        }


        // Run the animations
        _host.AddComponent<Amono>().StartCoroutine(Sequence());


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
        float client = 0;



        // A Function to create the animations
        IEnumerator Sequence()
        {
            var animation = Uanimation.TweenFloat.AddComponent(_host, new Uanimation.TweenFloat.Properties
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
            });;

            yield return animation.Coroutine();

            client = 0;

            yield return new WaitForSecondsRealtime(2);

            animation.Restart();

            yield return animation.Coroutine();

            Debug.LogAssertion("Finalizado");
        }



        // Run the animations
        _host.AddComponent<Amono>().StartCoroutine(Sequence());



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
