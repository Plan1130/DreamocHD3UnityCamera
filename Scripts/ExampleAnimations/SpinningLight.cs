using UnityEngine;

public class SpinningLight : MonoBehaviour
{
    public float spinSpeed = 30.0f;

    void Update()
    {
        transform.Rotate(Vector3.right, spinSpeed * Time.deltaTime);
    }
}