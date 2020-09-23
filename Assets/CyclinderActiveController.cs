using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyclinderActiveController : MonoBehaviour
{
    public List<GameObject> rightCylinder, leftCylinder = new List<GameObject>();
    public static List<GameObject> RightCylinder, LeftCylinder = new List<GameObject>();

    public void Start()
    {
        RightCylinder = rightCylinder;
        LeftCylinder = leftCylinder;
    }
}
