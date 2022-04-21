using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flipper : MonoBehaviour
{
    public Sprite[] CoinImages;
    public Image side;
    int Val;
    public int Coinvalue;

    public void Flip()
    {
        side.gameObject.GetComponent<Animator>().enabled = true;
        side.gameObject.GetComponent<Animator>().ResetTrigger("FlipCoin");
        side.gameObject.GetComponent<Animator>().SetTrigger("FlipCoin");

    }

    public void FlipTheCoin()
    {
        side.gameObject.GetComponent<Animator>().enabled = false;
        side.sprite = FlipCoin();
        Coinvalue = Val;
    }

    public Sprite FlipCoin()
    {
        int x = Mathf.RoundToInt(Random.Range(0, 1));
        Val = x + 1;
        return CoinImages[x];
    }
}
