using System.Linq;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests
{
    public class MainMenuStartTest
    {
        public const string SceneToLoad = "MainMenu";
        public const int SceneWaitTime = 3;
        public ToggleGroup toggleGroup;

        [UnitySetUp]
        public IEnumerator ToggleGroupSetup()
        {
            SceneManager.LoadScene(SceneToLoad);
            yield return new WaitForSeconds(SceneWaitTime);
            toggleGroup = Object.FindObjectOfType<ToggleGroup>();
        }

        [Test]
        public void MainMenuStartTestRun()
        {
            Assert.That(toggleGroup);
            Assert.IsNotNull(toggleGroup.GetComponent<MainMenu>());
            Assert.True(toggleGroup.GetComponent<MainMenu>());
        }
    }
}