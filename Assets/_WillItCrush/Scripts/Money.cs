using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public static int money = 0;
    public static int PerItemValue = 1;


    public void MoneyValueMinus(int minusValue)
    {
        money -= minusValue;
    }

    public void ChangeMoneyValue(int minusValue)
    {
        money += minusValue;
    }
}
