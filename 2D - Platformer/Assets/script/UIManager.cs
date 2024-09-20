using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // Tambahkan namespace ini untuk mengakses SceneManager

public class UIManager : MonoBehaviour
{
    public GameObject canvasMainMenu;
    public GameObject canvasPengaturan;
    public GameObject canvasKontrol;
    public GameObject canvasSuara;

    void Start()
    {
        // Pastikan semua canvas dalam keadaan tidak aktif di awal
        canvasPengaturan.SetActive(false);
        canvasKontrol.SetActive(false);
        canvasSuara.SetActive(false);
    }

    public void TampilkanPengaturan()
    {
        canvasMainMenu.SetActive(false);
        canvasPengaturan.SetActive(true);
        canvasKontrol.SetActive(false);
        canvasSuara.SetActive(false);
    }

    public void KembaliPengaturan()
    {
        canvasMainMenu.SetActive(true);
        canvasPengaturan.SetActive(false);
        canvasKontrol.SetActive(false);
        canvasSuara.SetActive(false);
    }

    public void TampilkanKontrol()
    {
        canvasMainMenu.SetActive(false);
        canvasPengaturan.SetActive(false);
        canvasKontrol.SetActive(true);
        canvasSuara.SetActive(false);
    }

    public void KembaliKontrol()
    {
        canvasMainMenu.SetActive(false);
        canvasPengaturan.SetActive(true);
        canvasKontrol.SetActive(false);
        canvasSuara.SetActive(false);
    }

    public void TampilkanSuara()
    {
        canvasMainMenu.SetActive(false);
        canvasPengaturan.SetActive(false);
        canvasKontrol.SetActive(false);
        canvasSuara.SetActive(true);
    }

    public void KembaliSuara()
    {
        canvasMainMenu.SetActive(false);
        canvasPengaturan.SetActive(true);
        canvasKontrol.SetActive(false);
        canvasSuara.SetActive(false);
    }

    // Fungsi untuk memindahkan ke scene lain
    public void PlayButton()
    {
        // Ganti "NamaScene" dengan nama scene yang ingin kamu pindah
        SceneManager.LoadScene("new_levelselection");
    }

    // Fungsi untuk keluar dari aplikasi
    public void ExitButton()
    {
        // Untuk aplikasi build, gunakan Application.Quit()
        Application.Quit();
#if UNITY_EDITOR
        // Jika dalam mode editor, stop play mode
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}