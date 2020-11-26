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
    public Text coinsClickValueText;

    // CPS
    public Text coinsPerSecondText;
    public double coinsPerSecond;

    // Click Upgrade 1 
    public Text clickUpgrade1Text;
    public int clickUpgrade1Level;
    public double clickUpgrade1Cost;

    // Click Upgrade 2 
    public Text clickUpgrade2Text;
    public double clickUpgrade2Cost;
    public int clickUpgrade2Level;

    // Prod Upgrade 1 
    public Text productionUpgrade1Text;
    public int productionUpgrade1Level;
    public double productionUpgrade1Cost;


    // Prod Upgrade 2 
    public Text productionUpgrade2Text;
    public int productionUpgrade2Level;
    public double productionUpgrade2Cost;
    public double productionUpgrade2Power;


    public void Start(){
        coinsClickValue = 1;
        coins = 0;
        clickUpgrade1Cost = 10;
        clickUpgrade2Cost = 50;
        productionUpgrade1Cost = 25;

        productionUpgrade2Power = 5;
        productionUpgrade2Cost = 250;
    }

    public void Update(){
        coinsPerSecond = productionUpgrade1Level + (productionUpgrade2Power * productionUpgrade2Level);
        
        coinsClickValueText.text = "Click\n+ " + coinsClickValue + " coins";
        coinsText.text = "Coins : " + coins.ToString("F0");
        coinsPerSecondText.text = coinsPerSecond.ToString("F0") + " coins/s";
        clickUpgrade1Text.text = "Click Upgrade 1\nCost: " + clickUpgrade1Cost.ToString("F0") + " coins\nPower : +1 Click\nLevel : " + clickUpgrade1Level;
        clickUpgrade2Text.text = "Click Upgrade 2\nCost: " + clickUpgrade2Cost.ToString("F0") + " coins\nPower : +5 Click\nLevel : " + clickUpgrade2Level;
    
        productionUpgrade1Text.text = "Production Upgrade 1\nCost: " + productionUpgrade1Cost.ToString("F0") + " coins\nPower : +1 coin/s\nLevel : " + productionUpgrade1Level;
        productionUpgrade2Text.text = "Production Upgrade 2\nCost: " + productionUpgrade2Cost.ToString("F0") + " coins\nPower : +" +productionUpgrade2Power+ " coin/s\nLevel : " + productionUpgrade2Level;

        coins += coinsPerSecond * Time.deltaTime;
    }

    // Main Click Button
    public void Click(){
        coins += coinsClickValue;
    }

    public void BuyClickUpgrade1(){
        if(coins > clickUpgrade1Cost){
            clickUpgrade1Level++;
            coinsClickValue++;
            coins -= clickUpgrade1Cost;
            clickUpgrade1Cost *= 1.07;
        }

    }


    public void BuyProductionUpgrade1(){
        if(coins > productionUpgrade1Cost){
            productionUpgrade1Level++;
            coins -= productionUpgrade1Cost;
            productionUpgrade1Cost *= 1.07;
        }

    }

    public void BuyProductionUpgrade2(){
        if(coins > productionUpgrade2Cost){
            productionUpgrade2Level++;
            coins -= productionUpgrade2Cost;
            productionUpgrade1Cost *= 1.75;
        }
    }

    public void BuyClickUpgrade2(){
        if(coins > clickUpgrade2Cost){
            clickUpgrade2Level++;
            coinsClickValue += 5;
            coins -= clickUpgrade2Cost;
            clickUpgrade2Cost *= 1.10;
        }

    }

}
