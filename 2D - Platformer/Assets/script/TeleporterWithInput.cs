using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterWithInput : MonoBehaviour
{
    public Transform targetTeleporter; // Objek tujuan teleportasi
    public KeyCode activationKey = KeyCode.W; // Tombol yang harus ditekan untuk teleportasi
    public float teleportCooldown = 2.0f; // Durasi cooldown setelah teleportasi
    public float fadeDuration = 1.0f; // Durasi animasi fade

    public GameObject cam1;
    public GameObject cam2;

    private Transform player; // Referensi ke player
    private bool canTeleport = true; // Status apakah player bisa teleportasi
    private static bool isTeleporting = false; // Status global apakah teleportasi sedang berlangsung
    private bool playerInRange = false; // Status apakah player dalam jangkauan teleportasi

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (playerInRange && canTeleport && !isTeleporting && Input.GetKeyDown(activationKey))
        {
            StartCoroutine(Teleport());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }

    IEnumerator Teleport()
    {
        canTeleport = false; // Cegah teleportasi lebih lanjut selama proses ini
        isTeleporting = true; // Set status global teleportasi

        // Fade out (jika ingin menambahkan animasi fade, tambahkan di sini)

        // Teleport player ke tujuan
        player.position = targetTeleporter.position;

        cam1.SetActive(false);
        cam2.SetActive(true);

        // Fade in (jika ingin menambahkan animasi fade, tambahkan di sini)

        // Tunggu selama durasi cooldown sebelum mengizinkan teleportasi lagi
        yield return new WaitForSeconds(teleportCooldown);
        canTeleport = true;
        isTeleporting = false; // Reset status global teleportasi
    }
}
