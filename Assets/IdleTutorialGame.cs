using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleTutorialGame : MonoBehaviour
{
    // Main click
    public double coins;
    public Text coinsText;
    public double coinsClickValue;

    // CPS
    public Text coinsPerSecondText;
    public double coinsPerSecond;

    // Click Upgrade 1 
    public Text clickUpgrade1Text;
    public int clickUpgrade1Level;
    public double clickUpgrade1Cost;

    // Prod Upgrade 1 
    public Text productionUpgrade1Text;
    public int productionUpgrade1Level;
    public double productionUpgrade1Cost;


    public void Start(){
        coinsClickValue = 1;
        coins = 0;
        clickUpgrade1Cost = 10;
        productionUpgrade1Cost = 25;
    }

    public void Update(){
        coinsPerSecond = productionUpgrade1Level;
        
        coinsText.text = "Coins : " + coins.ToString("F0");
        coinsPerSecondText.text = coinsPerSecond.ToString("F0") + " coins/s";
        clickUpgrade1Text.text = "Click Upgrade 1\nCost: " + clickUpgrade1Cost.ToString("F0") + " coins\nPower : +1 Click\nLevel : " + clickUpgrade1Level;
        productionUpgrade1Text.text = "Production Upgrade 1\nCost: " + productionUpgrade1Cost.ToString("F0") + " coins\nPower : +1 coin/s\nLevel : " + productionUpgrade1Level;
    
        coins += coinsPerSecond * Time.deltaTime;
    }

    // Main Click Button
    public void Click(){
        coins += coinsClickValue;
    }

    public void BuyClickUpgrade(){
        if(coins > clickUpgrade1Cost){
            clickUpgrade1Level++;
            coinsClickValue++;
            coins -= clickUpgrade1Cost;
            clickUpgrade1Cost *= 1.07;
        }

    }

    public void BuyProductionUpgrade(){
        if(coins > productionUpgrade1Cost){
            productionUpgrade1Level++;
            coins -= productionUpgrade1Cost;
            productionUpgrade1Cost *= 1.07;
        }

    }

}
