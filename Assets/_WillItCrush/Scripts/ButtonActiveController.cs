using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonActiveController : MonoBehaviour
{
    public Button ButtonSpeed, ButtonGravity, ButtonTooths, ButtonToothSize, ButtonMarketing, ButtonSpawnCubeTime;

    void Start()
    {
        ControllerFunc();
    }

    public void Controller(int ButtonValue, Button Button)
    {
        if (Money.money < ButtonValue)
        {
            Button.interactable = false;
        }
        else
        {
            Button.interactable = true;
        }
    }
    public void ControllerFunc()
    {
        Controller(GameInUpgrade1.sSpeedPrice, ButtonSpeed);
        Controller(GameInUpgrade1.sGravityPrice, ButtonGravity);
        Controller(GameInUpgrade1.sToothsPrice, ButtonTooths);
        Controller(GameInUpgrade1.sToothSizePrice, ButtonToothSize);
        Controller(GameInUpgrade1.sMarketingPrice, ButtonMarketing);
        Controller(GameInUpgrade1.sSpawnCubeTime, ButtonSpawnCubeTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        ControllerFunc();
    }
}