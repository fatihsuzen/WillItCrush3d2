using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BosstButtonEvent : MonoBehaviour
{
    public void StartBoost()
    {
        CyclinderTurn.cylinderRotSpeed = CyclinderTurn.cylinderRotSpeed * 2;
    }

    public void EndBoost()
    { 
        CyclinderTurn.cylinderRotSpeed = CyclinderTurn.cylinderRotSpeed / 2;        
    }
}
