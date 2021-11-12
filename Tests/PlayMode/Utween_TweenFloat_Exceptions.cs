using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        float client = 0;


        // Expect a log message
        LogAssert.Expect(LogType.Exception, "Exception: Expected exception");


        var tween = Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
        {
            animate = (x) =>
            {
                Debug.Log(x);
                client = x;
                throw new System.Exception("Expected exception");
            },
            keyframes = new Uanimators.TweenFloat.Keyframe[]
            {
                new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
            },
        });

        yield return new WaitForSecondsRealtime(.1f);
        Assert.IsTrue(tween.IsCompleted);
        Assert.NotNull(tween.Error);
        Assert.IsFalse(tween.enabled);

    }





    [UnityTest]
    public IEnumerator TweenFloat_WhenAnimatorComponentIsDestroyed()
    {

        // Host and client 
        float client = 0;

        // Expect a log message
        LogAssert.ignoreFailingMessages = true;

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
        float client = 0;
        float client2 = 0;
        float client3 = 0;


        // A Function to create the animations
        async void Sequence()
        {
            Debug.Log("Running animation with error");
            await Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
                {
                    
                    animate = (x) =>
                    {
                        Debug.Log(x);
                        throw new System.Exception("Expected Exception");
                    },
                    keyframes = new Uanimators.TweenFloat.Keyframe[]
                {
                    new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            }).Task();
            Debug.Log("Running animation with error");
            await Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
                {
                    
                    animate = (x) =>
                    {
                        Debug.Log(x);
                        client2 = x;
                    },
                    keyframes = new Uanimators.TweenFloat.Keyframe[]
                {
                    new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            }).Task();

            await Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
            {
                    
                    animate = (x) =>
                    {
                        Debug.Log(x);
                        client3 = x;
                    },
                    keyframes = new Uanimators.TweenFloat.Keyframe[]
                {
                    new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            }).Task();
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
        float client = 0;
        float client2 = 0;
        float client3 = 0;


        // A Function to create the animations
        IEnumerator Sequence()
        {
            Debug.Log("Running animation with error");
            yield return Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
            {
                
                animate = (x) =>
                {
                    Debug.Log(x);
                    throw new System.Exception("Expected Exception");
                },
                keyframes = new Uanimators.TweenFloat.Keyframe[]
                {
                    new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            }).Coroutine();
            Debug.Log("Running animation with error");

            yield return Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
            {
                
                animate = (x) =>
                {
                    Debug.Log(x);
                    client2 = x;
                },
                keyframes = new Uanimators.TweenFloat.Keyframe[]
                {
                    new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            }).Task();

            yield return Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
            {
                
                animate = (x) =>
                {
                    Debug.Log(x);
                    client3 = x;
                },
                keyframes = new Uanimators.TweenFloat.Keyframe[]
                {
                    new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            }).Task();
        }


        // Expect a log message, one from the Task and one is the log from the AnimatorCore
        LogAssert.ignoreFailingMessages = true;

        // Run the animations
        new GameObject().AddComponent<Amono>().StartCoroutine(Sequence());

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(1f);
        Assert.AreEqual(0f, client);
        Assert.AreEqual(0f, client2);
        Assert.AreEqual(0f, client3);


    }




    [UnityTest]
    public IEnumerator TweenFloat_DoesntAllowUnexpectedEnd_TaskErrorThrowWhenAnimatorComponentIsDestroyed()
    {

        // Host and client 
        float client = 0;
        float client2 = 0;
        float client3 = 0;

        TimeAnimatorCore animator;

        // A Function to create the animations
        async void Sequence()
        {
            Debug.Log("Running animation with error");
            animator = Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
            {

                animate = (x) =>
                {
                    Debug.Log(x);
                    throw new System.Exception("Expected Exception");
                },
                keyframes = new Uanimators.TweenFloat.Keyframe[]
                {
                    new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
                },
                allowUnexpectedEnd = false,
            });
            await animator.Task();
            Debug.Log("Running animation with error");

            await Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
            {
                
                animate = (x) =>
                {
                    Debug.Log(x);
                    client2 = x;
                },
                keyframes = new Uanimators.TweenFloat.Keyframe[]
                {
                    new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            }).Task();

            await Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
            {
                
                animate = (x) =>
                {
                    Debug.Log(x);
                    client3 = x;
                },
                keyframes = new Uanimators.TweenFloat.Keyframe[]
                {
                    new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            }).Task();
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
    public IEnumerator TweenFloat_AllowUnexpectedEnd_TaskWontBeCompleted()
    {

        // Host and client 
        GameObject host = new GameObject("Host");
        float client = 0;
        float client2 = 0;
        float client3 = 0;

        TimeAnimatorCore animator;


        // A Function to create the animations
        async Task Sequence()
        {
            Debug.Log("Running animation with error");
            animator = Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
            {
                
                animate = (x) =>
                {
                    Debug.Log(x);
                    throw new System.Exception("Expected Exception");
                },
                keyframes = new Uanimators.TweenFloat.Keyframe[]
                {
                    new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            });
            Debug.Log("Running animation with error");
            try
            {
                await animator.Task();
            }
            catch (System.Exception e)
            {
                Debug.LogError(e);
                throw e;
            }
            
            Debug.Log("Running animation with error");

            await Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
            {
                
                animate = (x) =>
                {
                    Debug.Log(x);
                    client2 = x;
                },
                keyframes = new Uanimators.TweenFloat.Keyframe[]
                {
                    new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            }).Task();

            await Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
            {
                
                animate = (x) =>
                {
                    Debug.Log(x);
                    client3 = x;
                },
                keyframes = new Uanimators.TweenFloat.Keyframe[]
                {
                    new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            }).Task();
        }


        // Any log Expected
        // LogAssert.ignoreFailingMessages = true;

        // Run the animations
        var tks = Sequence();
        Object.Destroy(animator);

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(5f);
        Debug.Log("Task: " + tks.Exception);
        Assert.AreNotEqual(20f, client2);
        Assert.AreNotEqual(20f, client3);

        


    }


    [UnityTest]
    public IEnumerator TweenFloat_NotAllowUnexpectedEnd_CorroutineThrowErrorWhenAnimatorComponentIsDestroyed()
    {

        // Host and client 
        GameObject host = new GameObject("Host");
        float client = 0;
        float client2 = 0;
        float client3 = 0;

        TimeAnimatorCore animator = null;

        // A Function to create the animations
        IEnumerator Sequence()
        {
            Debug.Log("Running animation with error");
            animator = Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
            {
                
                animate = (x) =>
                {
                    Debug.Log(x);
                    throw new System.Exception("Expected Exception");
                },
                keyframes = new Uanimators.TweenFloat.Keyframe[]
                {
                    new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
                },
                allowUnexpectedEnd = false,
            });
            yield return animator.Coroutine();

            Debug.Log("Running animation with error");

            yield return Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
            {
                
                animate = (x) =>
                {
                    Debug.Log(x);
                    client2 = x;
                },
                keyframes = new Uanimators.TweenFloat.Keyframe[]
                {
                    new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            }).Task();

            yield return Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
            {
                
                animate = (x) =>
                {
                    Debug.Log(x);
                    client3 = x;
                },
                keyframes = new Uanimators.TweenFloat.Keyframe[]
                {
                    new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            }).Task();
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



    [UnityTest]
    public IEnumerator TweenFloat_AllowUnexpectedEnd_CorroutineWillNeverBeCompleted()
    {

        // Host and client 
        GameObject host = new GameObject("Host");
        float client = 0;
        float client2 = 0;
        float client3 = 0;

        TimeAnimatorCore animator = null;

        // A Function to create the animations
        IEnumerator Sequence()
        {
            Debug.Log("Running animation with error");
            animator = Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
            {
                
                animate = (x) =>
                {
                    Debug.Log(x);
                    throw new System.Exception("Expected Exception");
                },
                keyframes = new Uanimators.TweenFloat.Keyframe[]
                {
                    new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            });
            yield return animator.Coroutine();
            Debug.Log("Running animation with error");

            yield return Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
            {
                
                animate = (x) =>
                {
                    Debug.Log(x);
                    client2 = x;
                },
                keyframes = new Uanimators.TweenFloat.Keyframe[]
                {
                    new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            }).Task();

            yield return Uanimators.TweenFloat.AddComponent(new GameObject("Host"), new Uanimators.TweenFloat.Properties
            {
                
                animate = (x) =>
                {
                    Debug.Log(x);
                    client3 = x;
                },
                keyframes = new Uanimators.TweenFloat.Keyframe[]
                {
                    new Uanimators.TweenFloat.Keyframe {key = 0, value = client},
                    new Uanimators.TweenFloat.Keyframe {key = 50, value = 3f},
                    new Uanimators.TweenFloat.Keyframe {key = 100, value = 20f},
                },
            }).Task();
        }


        // Any log message throw
        // LogAssert.ignoreFailingMessages = true;

        // Run the animations corroutine
        host.AddComponent<Amono>().StartCoroutine(Sequence());
        Object.Destroy(animator);

        // The animation will start and delay duration * iterations
        yield return new WaitForSecondsRealtime(5f);
        Assert.AreNotEqual(20f, client2);
        Assert.AreNotEqual(20f, client3);


    }


}
