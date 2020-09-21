using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSplit : MonoBehaviour
{
    public GameObject smallerObject;  
    public int touchCount;
    void Start()
    {
        touchCount = 0;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag=="Cutter")
        {
            touchCount++;
            if (touchCount == 4)
            {
                for (int i =0;i< 4; i++)
                {
                 Instantiate(smallerObject, new Vector3(transform.position.x, transform.position.y,transform.position.z), Quaternion.identity);
                }
                gameObject.SetActive(false);
            }            
        }     
    }
}
