using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public AmountOfPlayers aop;
    public PlayerNameInput p;
    private Text name;
    void Name()
    {
        if (aop.amountOfPlayers == 2)
            name.text = aop.playername1;
    }
}
        
        
        

        

