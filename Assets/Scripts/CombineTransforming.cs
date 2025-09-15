using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineTransforming : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] float _growthSpeed;
    [SerializeField] private float _rotationSpeed;

    private Vector3 _rotationAxis = Vector3.up;

    void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
        transform.localScale += Vector3.one * _growthSpeed * Time.deltaTime;
    }
}
