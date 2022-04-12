using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript2
{
    // A Test behaves as an ordinary method
    [Test]
    public void NewTestScript2SimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator NewTestScript2WithEnumeratorPasses()
    {
        Assert.IsNotNull(Button.GetComponent<+1000(2)>());
        Assert.True(Button.GetComponent<+1000(2)>());
        yield return null;
    }
}
