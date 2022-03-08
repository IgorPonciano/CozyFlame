using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotateAroundObject : MonoBehaviour
{
    [SerializeField] private float _cycleDuration;
    [SerializeField] private Vector3[] pathPoints = new Vector3[4];

    private void Start()
    {
        pathPoints[0] = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        pathPoints[1] = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
        pathPoints[2] = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
        pathPoints[3] = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        transform.DOLocalPath(pathPoints, _cycleDuration, PathType.CatmullRom,PathMode.Full3D).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Restart);
    }
}
