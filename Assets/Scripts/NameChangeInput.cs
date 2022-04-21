using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NameChangeInput : MonoBehaviour
{
    public Text p1;
    public Text p2;
    public Text p3;
    public Text p4;
    public AmountOfPlayers aop;
    void Start()
    {
        p1.text = aop.playername1;
        p2.text = aop.playername2;
        p3.text = aop.playername3;
        p4.text = aop.playername4;        
    }
}
