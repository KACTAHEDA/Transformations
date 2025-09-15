
using UnityEngine;

public class Scale : AllTransforms
{
    [SerializeField] float _growthByStep;

    protected override void CustomeTransform()
    {
        Scale(_growthByStep);
    }
}
