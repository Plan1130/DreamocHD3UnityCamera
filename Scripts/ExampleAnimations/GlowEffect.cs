using UnityEngine;

public class PulsingGlow : MonoBehaviour
{
    public Material material;
    public float pulseSpeed = 1.0f;
    private float emissionIntensity;

    void Update()
    {
        emissionIntensity = Mathf.PingPong(Time.time * pulseSpeed, 1.0f);
        material.SetColor("_EmissionColor", Color.white * emissionIntensity);
    }
}