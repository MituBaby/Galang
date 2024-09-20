using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public Slider volumeSlider; // Referensi ke slider

    private AudioSource bgmAudioSource;

    void Start()
    {
        // Cari instance dari BGMManager dan dapatkan AudioSource-nya
        bgmAudioSource = FindObjectOfType<BGMManager>().GetComponent<AudioSource>();

        // Set initial volume to the current slider value
        volumeSlider.value = bgmAudioSource.volume;

        // Add listener to slider to handle value changes
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    void SetVolume(float volume)
    {
        // Set the volume of the audio source to the slider value
        bgmAudioSource.volume = volume;
    }
}