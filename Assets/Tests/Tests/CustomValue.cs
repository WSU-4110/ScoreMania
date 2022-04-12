using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CustomValue
{
    // A Test behaves as an ordinary method
    [Test]
    public void CustomValueopens()
    {
    
    }


    [UnityTest]
    public IEnumerator CustomValueWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
