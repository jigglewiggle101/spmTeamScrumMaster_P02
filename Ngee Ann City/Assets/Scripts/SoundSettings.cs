using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public Slider volumeSlider; // Reference to the UI Slider
    public AudioSource backgroundMusic; // Reference to the Audio Source

    void Start()
    {
        // Ensure the slider value matches the current volume
        if (backgroundMusic != null && volumeSlider != null)
        {
            volumeSlider.value = backgroundMusic.volume;
            volumeSlider.onValueChanged.AddListener(ChangeVolume);
        }
    }

    void ChangeVolume(float value)
    {
        if (backgroundMusic != null)
        {
            backgroundMusic.volume = value;
        }
    }
}
