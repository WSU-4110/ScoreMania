using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests
{
    public class SplashScreenUpdateTest
    {
        public const string SceneToLoad = "SplashScreen";
        public const string NextScene = "MainMenu";
        public const int SceneWaitTime = 5;
        public VideoPlayer videoplayer;

        [UnitySetUp]
        public IEnumerator VideoPlayerSetup()
        {
            SceneManager.LoadScene(SceneToLoad);
            videoplayer = Object.FindObjectOfType<VideoPlayer>();
            yield return new WaitForSeconds(SceneWaitTime);
        }

        [Test]
        public void SplashScreenUpdateTestRun()
        {
            while (SceneManager.GetSceneByName("SplashScreen").isLoaded)
            {
                if (Input.anyKey)
                {SceneManager.LoadScene(NextScene);}
                // Tester shall press any key to proceed to the main menu.
                // If they don't and the video ends, the test will fail.

                if (SceneManager.GetSceneByName("MainMenu").isLoaded)
                {
                    break;
                }

                else
                {
                    // Random comaprison to fail the test
                    int num1 = 1, num2 = 2;
                    Assert.AreEqual(num1, num2);
                }
            }
        }
    }
}