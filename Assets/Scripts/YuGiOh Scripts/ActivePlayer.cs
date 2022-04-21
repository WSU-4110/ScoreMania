using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayer : MonoBehaviour
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
            player3.SetActive(false);
            player4.SetActive(false);
        }
        else 
        {
            player3.SetActive(true);
            player4.SetActive(true);
        }
    }
}
