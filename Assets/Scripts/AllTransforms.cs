using UnityEngine;

public abstract class AllTransforms : MonoBehaviour
{ 
    private Vector3 _rotationAxis = Vector3.up;

    private void Update()
    {
        CustomeTransform();
    }

    protected void Move(float speed)
    {
        transform.Translate(transform.forward * speed * Time.deltaTime);       
    }

    protected void Rotate(float rotationSpeed)
    {
        transform.Rotate(_rotationAxis * rotationSpeed * Time.deltaTime);
    }

    protected void Scale(float growthSpeed)
    {
        transform.localScale += Vector3.one * growthSpeed * Time.deltaTime;
    }

    protected abstract void CustomeTransform();
}
