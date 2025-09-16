
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(transform.forward * _speed * Time.deltaTime);
    }
}
