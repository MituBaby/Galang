using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingScene : MonoBehaviour
{
    // Waktu dalam detik sebelum berpindah ke scene berikutnya
    public float timeToWait = 10f;

    // Nama scene berikutnya yang akan dituju
    public string nextSceneName;

    void Start()
    {
        // Pastikan Time.timeScale diatur ke 1
        Time.timeScale = 1f;

        // Memulai coroutine untuk menunggu dan berpindah scene
        StartCoroutine(WaitAndLoadScene());
    }

    private IEnumerator WaitAndLoadScene()
    {
        // Menunggu selama waktu yang telah ditentukan
        yield return new WaitForSeconds(timeToWait);

        // Debugging log
        Debug.Log("Loading scene: " + nextSceneName);

        // Berpindah ke scene berikutnya
        SceneManager.LoadScene(nextSceneName);
    }
}
