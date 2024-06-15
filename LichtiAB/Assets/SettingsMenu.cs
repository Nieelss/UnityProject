using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Slider volumeSlider;
    public TMP_Dropdown graphicsDropdown;
    void Start()
    {
        if (AudioManager.Instance != null)
        {
            volumeSlider.value = AudioManager.Instance.volume;
        }
        volumeSlider.onValueChanged.AddListener(OnVolumeSliderChanged);

        graphicsDropdown.value = QualitySettings.GetQualityLevel();

        graphicsDropdown.onValueChanged.AddListener(delegate { ChangeGraphicsQuality(); });
    }

    private void OnVolumeSliderChanged(float value)
    {
        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.SetVolume(value);
        }
    }

    public void ChangeGraphicsQuality() 
    {
        QualitySettings.SetQualityLevel(graphicsDropdown.value);
    }
}
