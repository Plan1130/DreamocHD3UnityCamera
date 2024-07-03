using UnityEngine;

public class OrbitingObject : MonoBehaviour
{
    public Transform target;
    public float orbitSpeed = 50.0f;

    void Update()
    {
        transform.RotateAround(target.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}