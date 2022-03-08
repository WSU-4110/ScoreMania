using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    ToggleGroup toggleGroup;
    public AmountOfPlayers aop;
    void Start() { toggleGroup = GetComponent<ToggleGroup>(); }    
    public void getPlayerAmount() 
    {
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
        if (toggle.name == "2")
            aop.amountOfPlayers = 2;
        else if (toggle.name == "3")
            aop.amountOfPlayers = 3;        
        else
            aop.amountOfPlayers = 4;
    }
    public void gameStart()
    {
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
        aop.gameName = toggle.name;
        SceneManager.LoadScene(2);
    }
}
