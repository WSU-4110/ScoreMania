using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    ToggleGroup toggleGroup;
    public AmountOfPlayers aop;
    public int sceneIndex; 
    void Start()
    {
        toggleGroup = GetComponent<ToggleGroup>();
    }
    public void getPlayerAmount()
    {
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
        if (toggle.name == "2Players")
            aop.amountOfPlayers = 2;
        else if (toggle.name == "3Players")
            aop.amountOfPlayers = 3;
        else if (toggle.name == "4Players")
            aop.amountOfPlayers = 4;
    }
    public void gameStart()
    {
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
        aop.gameName = toggle.name;
        SceneManager.LoadScene(sceneIndex);
    }
}
