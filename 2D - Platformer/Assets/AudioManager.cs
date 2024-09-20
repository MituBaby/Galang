using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Daftar audio clip yang bisa dimainkan
    public AudioClip[] audioClips;

    // Komponen AudioSource yang akan digunakan untuk memutar audio
    private AudioSource audioSource;

    void Awake()
    {
        // Mengambil komponen AudioSource dari game object
        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            Debug.LogError("AudioSource component missing on " + gameObject.name);
        }
    }

    // Fungsi untuk memutar audio berdasarkan indeks dari daftar audio clip
    public void PlayAudioByIndex(int index)
    {
        if (index >= 0 && index < audioClips.Length)
        {
            audioSource.clip = audioClips[index];
            audioSource.Play();
        }
        else
        {
            Debug.LogError("Audio index out of range.");
        }
    }

    // Fungsi untuk memutar audio berdasarkan nama audio clip
    public void PlayAudioByName(string clipName)
    {
        AudioClip clipToPlay = null;

        foreach (AudioClip clip in audioClips)
        {
            if (clip.name == clipName)
            {
                clipToPlay = clip;
                break;
            }
        }

        if (clipToPlay != null)
        {
            audioSource.clip = clipToPlay;
            audioSource.Play();
        }
        else
        {
            Debug.LogError("Audio clip not found: " + clipName);
        }
    }
}
