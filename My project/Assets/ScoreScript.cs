using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private Text score;
    private int HealthScore;
    // Start is called before the first frame update
    void Start()
    {
        HealthScore = 20;
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = HealthScore.ToString();
    }
    public void AddScore(){
        HealthScore += 1;
    }
    public void SubScore(){
        HealthScore -= 1;
    }
}
