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
        //calls to get currently selected values as the values selected on last run of the program persist since they're stored on a scriptable object
        GetGameName();
        GetPlayerAmount();
    }

    public void GetGameName()
    {
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
        if (toggle.name == "MTG")
            aop.gameName = "MagicTheGathering";
        else if (toggle.name == "YGO")
            aop.gameName = "YuGiOh";
    }
    public void GetPlayerAmount()
    {
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
        if (toggle.name == "2Players")
            aop.amountOfPlayers = 2;
        else if (toggle.name == "3Players")
            aop.amountOfPlayers = 3;
        else if (toggle.name == "4Players")
            aop.amountOfPlayers = 4;
    }

    public void GameStart()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}