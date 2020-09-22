using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TransfromRight : MonoBehaviour
{
    float x;

    private void Start()
    {
        x = transform.position.x;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Ground")
        {
            // InvokeRepeating("RightMove", 0, 0.01f);
            transform.DOMoveX(0, 1);
        }
    }

    public void RightMove()
    {
        gameObject.gameObject.gameObject.transform.position = new Vector3(x += (Time.deltaTime * 2.5f), transform.position.y, transform.position.z);
        transform.transform.transform.transform.transform.position = new Vector3(x += (Time.deltaTime * 2.5f), transform.position.y, transform.position.z); ;
    }
}