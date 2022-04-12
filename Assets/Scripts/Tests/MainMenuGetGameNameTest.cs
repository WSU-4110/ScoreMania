using System;
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
    public class MainMenuGetGameNameTest
    {
        public const string SceneToLoad = "MainMenu";
        public const int SceneWaitTime = 5;
        public AmountOfPlayers aop;
        public AmountOfPlayers gameName;
        public ToggleGroup toggleGroup;
        public Toggle toggle;

        [UnitySetUp]
        public IEnumerator ToggleGroupSetup()
        {
            SceneManager.LoadScene(SceneToLoad);
            yield return new WaitForSeconds(SceneWaitTime);
            toggleGroup = GameObject.FindObjectOfType<ToggleGroup>();
            toggle = toggleGroup.ActiveToggles().FirstOrDefault(); 
        }

        [Test]
        public void MainMenuGetGameNameTestRun()
        {
            aop = ScriptableObject.CreateInstance<AmountOfPlayers>();
            Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
            if (toggle.name == "MTG")
                aop.gameName = "MagicTheGathering";
            else if (toggle.name == "YGO")
                aop.gameName = "YuGiOh";

            Assert.AreEqual("MagicTheGathering", aop.gameName);
            // Test if input is correct.
            // Tester shall choose Magic: The Gathering for this test.
            // Otherwise, the test will fail
        }
    }
}
