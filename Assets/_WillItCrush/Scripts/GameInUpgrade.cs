using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInUpgrade : MonoBehaviour
{
    Money Money = new Money();
    //ButtonGroupController ButtonGroupController = new ButtonGroupController();
    //public float Speed,Gravity,Tooths,ToothSize,Marketing;
    public int SpeedPrice, GravityPrice, ToothsPrice, ToothSizePrice, MarketingPrice;
    public Text SpeedInfoText, SpeedPriceText, GravityInfoText, GravityPriceText, ToothsInfoText, ToothsPriceText, ToothSizeInfoText, ToothSizePriceText, MarketingInfoText, MarketingPriceText;
    int SpeedInfoValue;
    //public Button ButtonSpeed, ButtonGravity, ButtonTooths, ButtonToothSize, ButtonMarketing;

    void Start()
    {
        //SpeedPriceText.text = SpeedPrice + "$";
        //GravityPriceText.text= GravityPrice.ToString();
        //ToothsPriceText.text= ToothsPrice.ToString();
        // ToothSizePriceText.text= ToothSizePrice.ToString();
        //MarketingPriceText.text= MarketingPrice.ToString();
    }
    public void SpeedButtonEvent()
    {
        SpeedInfoValue++;        
        SpeedPrice += 25;
        SpeedInfoText.text = SpeedInfoValue + "\n" + "rev/min";
        SpeedPriceText.text = SpeedPrice + "$";
        CylinderRotation.cylinderRotSpeed+=6f;
        Money.MoneyValueMinus(SpeedPrice);
       // ButtonGroupController.Controller(SpeedPrice, ButtonSpeed);
    }
}
