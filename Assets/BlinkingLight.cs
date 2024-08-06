using UnityEngine;

public class BlinkingLight : MonoBehaviour
{
    public Light lightToBlink; // Assign your light in the Inspector
    public float blinkInterval = 0.5f; // Interval in seconds

    private bool isLightOn = true;

    void Start()
    {
        if (lightToBlink == null)
        {
            lightToBlink = GetComponent<Light>();
        }
        InvokeRepeating("ToggleLight", blinkInterval, blinkInterval);
    }

    void ToggleLight()
    {
        if (lightToBlink != null)
        {
            isLightOn = !isLightOn;
            lightToBlink.enabled = isLightOn;
        }
    }
}
