using UnityEngine;
using DG.Tweening;

public class CyclinderTurn : MonoBehaviour
{
    public static int cylinderRotSpeed=200;
    public static float speed = 50f;    
    public bool left=false;
    public bool right = false;
    float way;
    public void Start()
    {
        if (left)
        {
            way = -1;
        }
        if (right)
        {
            way = 1;
        }
    }
    void Update()
    {
        transform.Rotate(new Vector3(0, way*Time.deltaTime * speed, 0), cylinderRotSpeed * Time.deltaTime);
    }
}