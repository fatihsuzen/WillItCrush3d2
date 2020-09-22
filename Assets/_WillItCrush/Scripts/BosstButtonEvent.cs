using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BosstButtonEvent : MonoBehaviour
{
    public void Boost(bool click)
    {
        if (click)
        {
            CylinderRotation.cylinderRotSpeed = CylinderRotation.cylinderRotSpeed * 2;
        }
        else
        {
            CylinderRotation.cylinderRotSpeed = CylinderRotation.cylinderRotSpeed / 2;
        }
    }

    public void StartBoost()
    {
        CylinderRotation.cylinderRotSpeed = CylinderRotation.cylinderRotSpeed * 2;
    }

    public void EndBoost()
    {
        CylinderRotation.cylinderRotSpeed = CylinderRotation.cylinderRotSpeed / 2;
    }
}
