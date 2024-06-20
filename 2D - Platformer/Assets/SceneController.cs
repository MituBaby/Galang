using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Fungsi untuk memindahkan scene ke scene utama atau scene sebelumnya
    public void GoBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Fungsi untuk memindahkan scene ke Level 1
    public void GoToLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    // Fungsi untuk memindahkan scene ke Level 2
    public void GoToLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    // Fungsi untuk memindahkan scene ke Level 3
    public void GoToLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
}