using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestScript
{
    [Test]
    public IEnumerator ButtonPushed()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(LoadScene);
        Debug.Log(_button.onClick.GetPersistentEventCount());
    }
    
}
