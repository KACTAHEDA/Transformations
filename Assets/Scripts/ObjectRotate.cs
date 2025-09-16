
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private Vector3 _rotationAxis = Vector3.up;

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(_rotationAxis * _rotationSpeed * Time.deltaTime);
    }
}
