using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaleing : MonoBehaviour
{
    [SerializeField] float _growthSpeed;

    private void FixedUpdate()
    {
        transform.localScale += Vector3.one * _growthSpeed * Time.deltaTime;
    }
}
