using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage1UI : MonoBehaviour
{
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

    public void KembaliMainMenu()
    {
        SceneManager.LoadScene("new_mainmenu");
    }
    public void TampilkanPengaturan()
    {
        canvasPengaturan.SetActive(true);
        canvasKontrol.SetActive(false);
        canvasSuara.SetActive(false);
    }

    public void KembaliPengaturan()
    {
        canvasPengaturan.SetActive(false);
        canvasKontrol.SetActive(false);
        canvasSuara.SetActive(false);
    }

    public void TampilkanKontrol()
    {
        canvasPengaturan.SetActive(false);
        canvasKontrol.SetActive(true);
        canvasSuara.SetActive(false);
    }

    public void KembaliKontrol()
    {
        canvasPengaturan.SetActive(true);
        canvasKontrol.SetActive(false);
        canvasSuara.SetActive(false);
    }

    public void TampilkanSuara()
    {
        canvasPengaturan.SetActive(false);
        canvasKontrol.SetActive(false);
        canvasSuara.SetActive(true);
    }

    public void KembaliSuara()
    {
        canvasPengaturan.SetActive(true);
        canvasKontrol.SetActive(false);
        canvasSuara.SetActive(false);
    }
}
