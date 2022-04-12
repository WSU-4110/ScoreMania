using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Test500
{
    // A Test behaves as an ordinary method
    [Test]
    public void Test500SimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator Test500WithEnumeratorPasses()
    {
        Assert.IsNotNull(Button.GetComponent<+500>());
        Assert.True(Button.GetComponent<+500>());
        yield return null;
    }
}
