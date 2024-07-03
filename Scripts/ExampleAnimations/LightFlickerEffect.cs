using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public Light flickerLight;
    public float minIntensity = 0.5f;
    public float maxIntensity = 2.0f;
    public float flickerSpeed = 10.0f;

    void Update()
    {
        float noise = Mathf.PerlinNoise(Time.time * flickerSpeed, 0.0f);
        flickerLight.intensity = Mathf.Lerp(minIntensity, maxIntensity, noise);
    }
}