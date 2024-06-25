using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Tambahkan ini untuk mengakses UI
using TMPro;

public class PopupTrigger : MonoBehaviour
{
    public GameObject popupCanvas; // Referensi ke Canvas popup
    public Image popupImage; // Referensi ke Image pada Canvas
    public Image bgimage;
    public Image bgimage2;
    public TextMeshProUGUI popupText; // Referensi ke Text pada Canvas

    public GameObject player;

    private Animator playeranim;

    private bool isPopupActive = false; // Status apakah popup sedang aktif

    void Start()
    {
        playeranim = player.GetComponent<Animator>();
        // Pastikan popup dalam keadaan tidak aktif saat memulai
        popupCanvas.SetActive(false);
    }

    void Update()
    {
        // Memeriksa klik mouse ketika popup aktif
        if (isPopupActive && Input.GetMouseButtonDown(0))
        {
            // Menonaktifkan popup saat di-klik
            popupCanvas.SetActive(false);
            isPopupActive = false;

            player.GetComponent<PlayerMovement>().enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Mengaktifkan popup saat player menabrak trigger
            popupCanvas.SetActive(true);
            isPopupActive = true;

            player.GetComponent<PlayerMovement>().enabled = false;
            playeranim.SetFloat("Speed", 0);

            // Menonaktifkan sprite dan collider objek trigger setelah ditabrak oleh player
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<Collider2D>().enabled = false;
        }
    }
}