using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class BosstButtonEvent : MonoBehaviour
{
    public Button button;

  
    public void Boost(bool click)
    {
        if(click)
        {
            CylinderRotation.cylinderRotSpeed = CylinderRotation.cylinderRotSpeed * 2;
        }
        else
        {
            CylinderRotation.cylinderRotSpeed = CylinderRotation.cylinderRotSpeed / 2;
        }
    }
}
