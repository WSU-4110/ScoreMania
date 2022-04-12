using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;


namespace Tests
{
    public class SplashScreenStartTest
    {
        public const string SceneToLoad = "SplashScreen";
        public const int SceneWaitTime = 2;
        public VideoPlayer videoplayer;

        [UnitySetUp]
        public IEnumerator VideoPlayerSetup()
        {
            SceneManager.LoadScene(SceneToLoad);
            yield return new WaitForSeconds(SceneWaitTime);
            videoplayer = Object.FindObjectOfType<VideoPlayer>();
        }

        [Test]
        public void SplashScreenStartTestRun()
        {
            Assert.IsNotNull(videoplayer.GetComponent<SplashScreen>());
            Assert.True(videoplayer.GetComponent<SplashScreen>());
        }
    }
}
