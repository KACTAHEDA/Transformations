
using UnityEngine;

public class ObjectScale : MonoBehaviour
{
    [SerializeField] private float _growthSpeed;

    private void Update()
    {
        Scale();
    }

    private void Scale()
    {
        transform.localScale += Vector3.one * _growthSpeed * Time.deltaTime;
    }
}
