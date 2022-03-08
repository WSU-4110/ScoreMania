using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SplashScreen : MonoBehaviour
{
    public float timer = 10f;    
    void Update()
    {
        timer -= Time.deltaTime;        
        if (timer <= 0) { SceneManager.LoadScene(1); }
    }
}
