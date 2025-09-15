
using UnityEngine;

public class Move : AllTransforms
{
    [SerializeField] private float _speed;

    protected override void CustomeTransform()
    {
        Move(_speed);
    }
}
