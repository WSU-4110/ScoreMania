using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class AmountOfPlayers : ScriptableObject
{
    public int amountOfPlayers;
    public string gameName;
    public string playername1;
    public string playername2;
    public string playername3;
    public string playername4;

    public static implicit operator AmountOfPlayers(string v)
    {
        throw new NotImplementedException();
    }
}
