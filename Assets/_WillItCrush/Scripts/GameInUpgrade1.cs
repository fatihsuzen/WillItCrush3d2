using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameInUpgrade1 : MonoBehaviour
{
    public Money Money;
    public ButtonActiveController ButtonActiveController;
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
    float Toothsize = 0.1f, GravityValue=-10;
    public static int[] StaticIntArray= new int[10]; 

    void Start()
    {
        InvokeRepeating("ForBtnActiveStaticInt", 0, 0.1f);
        GravityValue += GravityEventValue * Time.deltaTime;
        Physics.gravity = new Vector3(0, GravityValue, 0);
    }
    public void SpeedButtonEvent()
    {        
        SpeedInfoValue += SpeedEventValue;
        buttonTextFunc(SpeedPrice, SpeedInfoValue, SpeedInfoText, "rev/min");
        SpeedPrice += 15;
        SpeedPriceText.text = SpeedPrice + " $";        
        CyclinderTurn.cylinderRotSpeed += (int)6f;

    }
    public void GravityButtonEvent()
    {
        GravityInfoValue += 0.1f;
        buttonTextFunc(GravityPrice, GravityInfoValue, GravityInfoText, "m/s2");       
        GravityPriceText.text = GravityPrice + " $";
        GravityValue += GravityEventValue * Time.deltaTime;
        Physics.gravity = new Vector3(0, GravityValue, 0);
    }
    public void ToothButtonEvent()
    {
        ToothsInfoValue += ToothsEventValue;
        buttonTextFunc(ToothsPrice, ToothsInfoValue, ToothsInfoText, "per roll");       
        ToothsPriceText.text = ToothsPrice + " $";
        CurrentCylinder += (int)ToothsEventValue;
        CylinderToothActiveController(CurrentCylinder);        
    }
    public void ToothSizeButtonEvent()
    {
        Money.ChangeMoneyValue(-ToothSizePrice);
        Toothsize += ToothSizeEventValue;
        for (int i = 0; i < ToothObjectForSize.Count; i++)
        {
            ToothObjectForSize[i].transform.localScale = new Vector3(Toothsize, 1.99f, Toothsize);
        }
        ToothSizeInfoValue +=5;
        ToothSizeInfoText.text = ToothSizeInfoValue + "\n" + "Meters";
    }
    public void MarketingButtonEvent()
    {
        MarketingInfoValue += MarketingEventValue;
        buttonTextFunc(MarketingPrice, MarketingInfoValue, MarketingInfoText, "$/item");        
        MarketingPriceText.text = MarketingPrice + " $";
        Money.PerItemValue += (int)MarketingEventValue;
    }
    public void SpawnCubeTimeButtonEvent()
    {
        if (0.4f < SpawnerCube.SpawnCubetime)
        {
            buttonTextFunc(SpawnCubeTimePrice, SpawnCubeTimeInfoValue, SpawnCubeTimeInfoText, "sec");
            SpawnCubeTimeInfoValue -= SpawnCubeTimeEventValue;
            SpawnerCube.SpawnCubetime -= SpawnCubeTimeEventValue;
        }


    }
    public void CylinderToothActiveController(int CurrentCylinder)
    {
        CyclinderActiveController.LeftCylinder[CurrentCylinder].SetActive(true);
        CyclinderActiveController.RightCylinder[CurrentCylinder].SetActive(true);
        CyclinderActiveController.LeftCylinder[CurrentCylinder - 1].SetActive(false);
        CyclinderActiveController.RightCylinder[CurrentCylinder - 1].SetActive(false);
    }
    public void ForBtnActiveStaticInt()
    {
        StaticIntArray[0] = SpeedPrice;
        StaticIntArray[1] = GravityPrice;
        StaticIntArray[2] = ToothsPrice;
        StaticIntArray[3] = ToothSizePrice;
        StaticIntArray[4] = MarketingPrice;
        StaticIntArray[5] = SpawnCubeTimePrice;
    }
    public void buttonTextFunc(float buttonPrice, float buttonInfoValue, TextMeshProUGUI InfoText, string unitText)
    {
        Money.ChangeMoneyValue(-buttonPrice);        
        InfoText.text = buttonInfoValue+"\n"+unitText;
        ForBtnActiveStaticInt();
        ButtonActiveController.ControllerFunc();
    }
}
