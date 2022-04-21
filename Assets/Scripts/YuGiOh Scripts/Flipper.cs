using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flipper : MonoBehaviour
{
    private const bool V = true;
    public Sprite[] CoinImages;
    public Image Side;
    int currentVal;
    public int Coinvalue;


    public void Flip()
    {
        Side.gameObject.GetComponent<Animator>().enabled= V;
        Side.gameObject.GetComponent<Animator>().ResetTrigger("FlipCoin");
        Side.gameObject.GetComponent<Animator>().SetTrigger("FlipCoin");
    }
    public void FlipTheCoin()
    {
        Side.gameObject.GetComponent<Animator>().enabled = false;
        Side.sprite = FlipCoin();
        Coinvalue = currentVal;
    }

    public Sprite FlipCoin()
    {
        int x = Mathf.RoundToInt(Random.Range(0, CoinImages.Length - 1));
        currentVal = x ;
        return CoinImages[x];
    }
}