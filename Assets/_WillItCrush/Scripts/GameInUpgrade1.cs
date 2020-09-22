using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameInUpgrade1 : MonoBehaviour
{
    public Money Money;

    //START PRICE TEXT VALUES IN BUTTON
    public int SpeedPrice, GravityPrice, ToothsPrice, ToothSizePrice, MarketingPrice, SpawnCubeTimePrice;
    //STATIC VALUES
    public static int sSpeedPrice, sGravityPrice, sToothsPrice, sToothSizePrice, sMarketingPrice, sSpawnCubeTime;
    //TEXTS
    public TextMeshProUGUI SpeedInfoText, SpeedPriceText, GravityInfoText, GravityPriceText, ToothsInfoText, ToothsPriceText, ToothSizeInfoText, ToothSizePriceText, MarketingInfoText, MarketingPriceText, SpawnCubeTimeInfoText, SpawnCubeTimePriceText;
    //INFO TEXT VALUE IN BUTTON
    public float SpeedInfoValue, GravityInfoValue, ToothsInfoValue, ToothSizeInfoValue, MarketingInfoValue, SpawnCubeTimeInfoValue;
    //EVENT VALUES
    public float SpeedEventValue, GravityEventValue, ToothsEventValue, ToothSizeEventValue, MarketingEventValue, SpawnCubeTimeEventValue;
    public List<GameObject> ToothObjectForSize = new List<GameObject>();
    public static int CurrentCylinder;
    float Toothsize = 0.1f, GravityValue;

    void Start()
    {
        InvokeRepeating("ForBtnActiveStaticInt", 0, 0.1f);
        //SPEED EVENT
        SpeedPriceText.text = SpeedPrice + "$";
        SpeedInfoText.text = SpeedInfoValue + "\n" + "rev/min";
        //GRAVITY EVENT
        GravityPriceText.text = GravityPrice.ToString();
        GravityValue = -500f * Time.deltaTime;
        Physics.gravity = new Vector3(0, GravityValue, 0);
        //TOOTHS EVENT
        ToothsPriceText.text = ToothsPrice.ToString();
        ToothSizePriceText.text = ToothSizePrice.ToString();
        //TOOTHS SİZE EVENT
        ToothSizeInfoText.text = ToothSizeInfoValue + "\n" + "meters";
        //MARKETING EVENT
        MarketingPriceText.text = MarketingPrice.ToString();
        MarketingInfoText.text = MarketingInfoValue + "\n" + "$/item";
        //SpawnCubeTime EVENT
        SpawnCubeTimePriceText.text = SpawnCubeTimePrice.ToString();
        SpawnCubeTimeInfoText.text = SpawnCubeTimeInfoValue + "\n" + "sec";



    }
    public void SpeedButtonEvent()
    {
        Money.MoneyValueMinus(SpeedPrice);
        SpeedInfoValue++;
        SpeedPrice += 15;
        SpeedInfoText.text = SpeedInfoValue + "\n" + "rev/min";
        SpeedPriceText.text = SpeedPrice + "$";
        CylinderRotation.cylinderRotSpeed += 6f;
    }
    public void GravityButtonEvent()
    {
        Money.ChangeMoneyValue(-GravityPrice);
        GravityInfoValue += 0.1f;
        GravityInfoText.text = GravityInfoValue + "\n" + "m/s2";
        GravityValue -= GravityEventValue * Time.deltaTime;
        Physics.gravity = new Vector3(0, GravityValue, 0);
    }
    public void ToothButtonEvent()
    {
        if (CurrentCylinder < CylinderRotation.sLeftCylinder.Count - 1)
        {
            Money.MoneyValueMinus(ToothsPrice);
            ToothsInfoValue += ToothsEventValue;
            ToothsInfoText.text = ToothsInfoValue + "\n" + "per roll";
            CurrentCylinder += (int)ToothsEventValue;
            CylinderToothActiveController(CurrentCylinder);
        }
    }
    public void ToothSizeButtonEvent()
    {
        Money.MoneyValueMinus(ToothSizePrice);
        Toothsize += ToothSizeEventValue;

        for (int i = 0; i < ToothObjectForSize.Count; i++)
        {
            ToothObjectForSize[i].transform.localScale = new Vector3(Toothsize, 1.99f, Toothsize);
        }
    }
    public void MarketingButtonEvent()
    {
        Money.MoneyValueMinus(MarketingPrice);
        MarketingInfoValue += MarketingEventValue;
        MarketingInfoText.text = MarketingInfoValue + "\n" + "$/item";
        Money.PerItemValue += (int)MarketingEventValue;
    }
    public void SpawnCubeTimeButtonEvent()
    {
        if (0.4f < SpawnerCube.SpawnCubetime)
        {
            Money.MoneyValueMinus(SpawnCubeTimePrice);
            SpawnCubeTimeInfoValue -= SpawnCubeTimeEventValue;
            SpawnCubeTimeInfoText.text = SpawnCubeTimeInfoValue + "\n" + "sec";
            SpawnerCube.SpawnCubetime -= SpawnCubeTimeEventValue;
        }

    }
    public void CylinderToothActiveController(int CurrentCylinder)
    {
        CylinderRotation.sLeftCylinder[CurrentCylinder].SetActive(true);
        CylinderRotation.sRightCylinder[CurrentCylinder].SetActive(true);
        CylinderRotation.sLeftCylinder[CurrentCylinder - 1].SetActive(false);
        CylinderRotation.sRightCylinder[CurrentCylinder - 1].SetActive(false);
    }
    public void ForBtnActiveStaticInt()
    {
        sSpeedPrice = SpeedPrice;
        sGravityPrice = GravityPrice;
        sToothsPrice = ToothsPrice;
        sToothSizePrice = ToothSizePrice;
        sMarketingPrice = MarketingPrice;
        sSpawnCubeTime = SpawnCubeTimePrice;
    }
}
