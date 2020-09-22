using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

using UnityEngine;

public class MoneyCounter : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    private void OnCollisionEnter(Collision collision)
    {
        Money.money += Money.PerItemValue;
        MoneyRefreshText();
        Destroy(collision.gameObject);
    }
    public void MoneyRefreshText()
    {
        moneyText.text = Money.money.ToString() + "$";
    }
}
