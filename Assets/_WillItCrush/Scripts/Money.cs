using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public static float money=10000;
    public static int PerItemValue = 1;
    public void ChangeMoneyValue(float Value)
    {
        money += Value;
    }
}
