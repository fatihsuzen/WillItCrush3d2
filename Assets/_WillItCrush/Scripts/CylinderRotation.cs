using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotation : MonoBehaviour
{
    public List<GameObject> RightCylinder, LeftCylinder = new List<GameObject>();
    public static List<GameObject> sRightCylinder, sLeftCylinder = new List<GameObject>();
    public static float speed = 50f;
    public static float cylinderRotSpeed = 100f;
    float rot;

    void Start()
    {
        sRightCylinder = RightCylinder;
        sLeftCylinder = LeftCylinder;
    }

    void Update()
    {
        rot = Time.deltaTime * speed;
        CylinderRotationFunc(GameInUpgrade1.CurrentCylinder);
    }

    public void CylinderRotationFunc(int CurrentCylinder)
    {
        LeftCylinder[CurrentCylinder].transform.Rotate(new Vector3(0, -rot, 0), cylinderRotSpeed * Time.deltaTime);
        RightCylinder[CurrentCylinder].transform.Rotate(new Vector3(0, rot, 0), cylinderRotSpeed * Time.deltaTime);
    }
}
