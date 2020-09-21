using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public static int money=0, PerItemValue=1;
    public void MoneyValueMinus(int minusValue)
    {
        money -= minusValue;
    }
}
