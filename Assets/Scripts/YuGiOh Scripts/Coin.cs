using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    Animator anim; 
    public Flipper myFlipper;
    public bool one;
    public void Flipper()
    {
        if (one)
            myFlipper.FlipTheCoin();
    }
}
