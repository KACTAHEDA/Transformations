
using UnityEngine;

public class Rotate : AllTransforms
{
    [SerializeField] private float _speedOfRotation;

    protected override void CustomeTransform()
    {
        Rotate(_speedOfRotation);
    }
}
