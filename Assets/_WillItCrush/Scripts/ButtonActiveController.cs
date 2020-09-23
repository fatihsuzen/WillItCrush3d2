using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonActiveController : MonoBehaviour
{
    public List<Button> buttonList = new List<Button>();
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
        for (int i = 0; i < buttonList.Count; i++)
        {
            Controller(GameInUpgrade1.StaticIntArray[i], buttonList[i]);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        ControllerFunc();
    }
}