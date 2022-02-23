using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Calculator : MonoBehaviour

{
    [SerializeField]
    Text inputF;
    string inputString;
    string opSymbol;
    int[] number = new int[2];
    int i = 0;
    int total;
    bool shownTotal = false;

   public void ButtonPressed()
    {
      //  if (shownTotal  == true)
       // {
       //     inputString = "";
      //      inputF.text = "";
      //      shownTotal = false;
      //  }
       // Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        string buttonValue = EventSystem.current.currentSelectedGameObject.name;
        inputString += buttonValue;
        inputF.text = inputString;


      /*  int arg;
        if(int.TryParse(buttonValue, out arg))
        {
            if (i > 1) i = 0;
            number[i] = arg;
            i = i + 1;
        }

        else
        {
            switch(buttonValue)
            {
                case "+":
                    opSymbol = buttonValue;
                    break;
                    
                case "-":
                    opSymbol = buttonValue;
                    break;

                case "=":
                    switch(opSymbol)
                    {
                        case "+":
                            total = number[0] + number[i];
                            break;
                        case "-":
                            total = number[0] - number[i];
                            break;
                    }

                    shownTotal = true;
                    inputString = total.ToString();
                   // number = new int[2];
                    break;
            }
        }

        //inputString = (total.Equals("")) ? inputString + total : inputString;
      */
    }

}
