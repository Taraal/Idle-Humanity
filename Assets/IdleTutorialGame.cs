using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleTutorialGame : MonoBehaviour
{
    public Text coinsText;
    public double coins;

    public void Start(){
        coins = 123;
    }

    public void Update(){
        coinsText.text = "Coins : " + coins;
    }

    public void Click(){
        coins += 1;
    }
}
