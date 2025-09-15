
using UnityEngine;

public class CombineTransform : AllTransforms
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] float _growthSpeed;
    [SerializeField] private float _rotationSpeed;

    protected override void CustomeTransform()
    {
        Move(_moveSpeed);
        Scale(_growthSpeed);
        Rotate(_rotationSpeed);
    }
}
