using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMManager2 : MonoBehaviour
{
    private static BGMManager2 instance;

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
            Destroy(gameObject);
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
