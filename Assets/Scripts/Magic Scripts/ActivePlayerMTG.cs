using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayerMTG : MonoBehaviour
{
    // Start is called before the first frame update
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
}
