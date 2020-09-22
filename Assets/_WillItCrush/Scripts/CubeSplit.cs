using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSplit : MonoBehaviour
{
    public GameObject smallerObject;
    public int touchCount;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "Cutter")
            return;

        touchCount++;

        if (touchCount != 4)
            return;

        for (int i = 0; i < 4; i++)
        {
            Instantiate(smallerObject, transform.position, Quaternion.identity);
        }
        gameObject.SetActive(false);
    }
}