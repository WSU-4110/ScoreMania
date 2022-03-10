using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score2 : MonoBehaviour
{
    abstract class pointChange
    { adPoints1000 adPoints1000;
        subtpoints1000 subtPoints1000;


        public pointChange(adPoints1000 adPoints1000,
        subtpoints1000 subtPoints1000;)
         {
        this.adPoints1000 = adPoints1000;
        this.subtPoints1000 = subtPoints1000;
         }

    private Text HealthPoints;
        private int healthScore;
        // Start is called before the first frame update
       

        void begin()
        {
            healthScore = 8000;
            HealthPoints = GetComponent<Text>();
        }

        // Update is called once per frame
        void updoot()
        {
            HealthPoints.text = healthScore.ToString();
        }

        public void adPoints1000()
        {
            healthScore += 1000;
        }

        public void adPoints500()
        {
            healthScore += 500;
        }

        public void adPoints100()
        {
            healthScore += 100;
        }

        public void adPoints50()
        {
            healthScore += 50;
        }

        public void subtPoints1000()
        {
            healthScore -= 1000;
        }

        public void subtPoints500()
        {
            healthScore -= 500;
        }

        public void subtPoints100()
        {
            healthScore -= 100;
        }

        public void subtPoints50()
        {
            healthScore -= 50;
        }
    }
}
