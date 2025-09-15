using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveming : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }
}
