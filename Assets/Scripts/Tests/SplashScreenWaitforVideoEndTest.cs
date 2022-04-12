using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests
{
    public class SplashScreenWaitforVideoEndTest
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
        public void SplashScreenWaitforVideoEndTestRun()
        {
            SceneManager.LoadScene(NextScene);
        }
    }
}