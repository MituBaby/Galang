using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMManager1 : MonoBehaviour
{
    private static BGMManager1 instance;

    private AudioSource bgmAudioSource;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            bgmAudioSource = GetComponent<AudioSource>();
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name != "Limitation")
        {
            if (bgmAudioSource.isPlaying)
            {
                bgmAudioSource.Stop();
            }
        }
        else
        {
            if (!bgmAudioSource.isPlaying)
            {
                bgmAudioSource.Play();
            }
        }
    }
}