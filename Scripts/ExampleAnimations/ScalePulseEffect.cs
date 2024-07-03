using UnityEngine;

public class ScalePulseEffect : MonoBehaviour
{
    public float pulseSpeed = 1.0f;
    public float scaleFactor = 0.1f;
    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        float scale = 1.0f + Mathf.Sin(Time.time * pulseSpeed) * scaleFactor;
        transform.localScale = originalScale * scale;
    }
}