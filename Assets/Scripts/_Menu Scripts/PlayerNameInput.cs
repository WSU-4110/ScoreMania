using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerNameInput : MonoBehaviour
{
    public AmountOfPlayers aop;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    void Start()
    {
        if (aop.amountOfPlayers == 2)
        {
            player1.SetActive(true);
            player2.SetActive(true);
            player3.SetActive(false);
            player4.SetActive(false);
        }
        else if (aop.amountOfPlayers == 3)
        {
            player1.SetActive(true);
            player2.SetActive(true);
            player3.SetActive(true);
            player4.SetActive(false);
        }
        else 
        {
            player1.SetActive(true);
            player2.SetActive(true);
            player3.SetActive(true);
            player4.SetActive(true);
        }
    }
    public void getName() 
    {        
        aop.playername1 = player1.GetComponentInChildren<Text>().text;
        aop.playername2 = player2.GetComponentInChildren<Text>().text;
        aop.playername3 = player3.GetComponentInChildren<Text>().text;
        aop.playername4 = player4.GetComponentInChildren<Text>().text;
    }
    public void backButton() 
    {
        SceneManager.LoadScene(1);
    }
}
