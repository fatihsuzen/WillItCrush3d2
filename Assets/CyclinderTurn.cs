using UnityEngine;
using DG.Tweening;

public class CyclinderTurn : MonoBehaviour
{
    public int cylinderRotSpeed;
    public int rot;

    int speed;

    private void Start()
    {
        transform.DORotate(Vector3.up * 360, 3, RotateMode.LocalAxisAdd).SetLoops(-1);
    }
}