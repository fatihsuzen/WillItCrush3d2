using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TransfromRight : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Ground")
        {
            // InvokeRepeating("RightMove", 0, 0.01f);
            transform.DOMoveX(8,3);
        }
    }  
}