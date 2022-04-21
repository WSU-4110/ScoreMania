using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dce : MonoBehaviour
{
    Animator anim;

    public Roller myRoller;
    public bool One;
    public void Roller()
    {
        if (One)
            myRoller.RollDiceOneFuntion();

    }
}
