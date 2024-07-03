using UnityEngine;

public class FloatAnimation : MonoBehaviour
{
    public float amplitude = 0.5f;
    public float frequency = 1.0f;

    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float yOffset = Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = new Vector3(startPos.x, startPos.y + yOffset, startPos.z);
    }
}