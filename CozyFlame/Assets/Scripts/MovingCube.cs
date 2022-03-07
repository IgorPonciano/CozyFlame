using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingCube : MonoBehaviour
{
    [SerializeField] private float _cycleLenght = 2;
    [SerializeField] private float _shakePower = 1;
    private MeshRenderer _meshRend;
    private void Start()
    {
        transform.DOMove(new Vector3(10, 0, 0), _cycleLenght).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
        transform.DOShakeScale(_cycleLenght, _shakePower, 10, 60, true).SetLoops(-1, LoopType.Restart);
        _meshRend = gameObject.GetComponent<MeshRenderer>();
        _meshRend.material.DOColor(Color.red, _cycleLenght).SetLoops(-1, LoopType.Yoyo);
    }
}
