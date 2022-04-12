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
    public class MainMenuGetPlayerAmountTest
    {
        public const string SceneToLoad = "MainMenu";
        public const int SceneWaitTime = 5;
        public AmountOfPlayers aop;
        public AmountOfPlayers amountOfPlayers;
        public ToggleGroup toggleGroup;
        public Toggle toggle;

        [UnitySetUp]
        public IEnumerator ToggleGroupSetup()
        {
            SceneManager.LoadScene(SceneToLoad);
            yield return new WaitForSeconds(SceneWaitTime);
            toggleGroup = GameObject.FindObjectOfType<ToggleGroup>();
        }

        [Test]
        public void MainMenuGetPlayerAmountTestRun()
        {
            aop = ScriptableObject.CreateInstance<AmountOfPlayers>();
            Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
            if (toggle.name == "2Players")
                aop.amountOfPlayers = 2;
            else if (toggle.name == "3Players")
                aop.amountOfPlayers = 3;
            else if (toggle.name == "4Players")
                aop.amountOfPlayers = 4;

            Assert.AreEqual(2, aop.amountOfPlayers);
            // Test if input is correct.
            // Tester shall choose 2 for this test.
            // Otherwise, the test will fail.
        }
    }
}