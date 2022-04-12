using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scoreCount : MonoBehaviour
{
   
    private Text LifePoints;
    private int lifeScore;
    // Start is called before the first frame update
    void Start()
    {
        lifeScore = 8000;
        LifePoints = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        LifePoints.text = lifeScore.ToString();
    }

    public void addPoints1000()
    {
        lifeScore += 1000;
    }

    public void addPoints500()
    {
        lifeScore += 500;
    }

    public void addPoints100()
    {
        lifeScore += 100;
    }

    public void addPoints50()
    {
        lifeScore += 50;
    }

    public void subPoints1000()
    {
        lifeScore -= 1000;
    }

    public void subPoints500()
    {
        lifeScore -= 500;
    }

    public void subPoints100()
    {
        lifeScore -= 100;
    }

    public void subPoints50()
    {
        lifeScore -= 50;
    }

    public void resetScore()
    {
        lifeScore = 8000;
    }
}
