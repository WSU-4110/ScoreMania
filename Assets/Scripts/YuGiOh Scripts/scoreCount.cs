using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class scoreCount : MonoBehaviour
{

    private Text LifePoints;
    private int lifeScore;
    Text InputField;
    string inputString;
    string operatorsym; 
    int i = 0;
    bool displayed = false; 

    int[] number = new int[1];
    int result = 0; 
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

    public void Calculator()
    {


    }

    public void ButtonPressed()
    {
        clear();
        string buttonVal = EventSystem.current.currentSelectedGameObject.name;
        int arg;
        inputString += buttonVal;



        if ( int.TryParse(buttonVal, out arg))
        {
            if (i > 1) i = 0; 
            number[i] = arg;
            i += 1; 
        } else
        {
            switch(buttonVal)
            {
                case "+":
                    operatorsym = "+";
                    break;
                case "-":
                    operatorsym = "-";
                    break;
                case "=":
                    switch (operatorsym)
                    {
                        case "+":
                            result = lifeScore + number[0];
                            break;
                        case "-":
                            result = lifeScore - number[0];
                            break; 
                    }
                    displayed = true; 
                    inputString = result.ToString();
                    number = new int[1]; 
                    break; 

            }
        }
    

        InputField.text = inputString; 


    }

    public void clear()
    {
        if ( displayed == true)
        {
            InputField.text = "";
            inputString = "";
            displayed = false; 
        }

    }


}

