using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Teleporter : MonoBehaviour
{
    public Transform[] destinations; // Daftar objek tujuan teleportasi
    public float fadeDuration = 1.0f; // Durasi animasi fade
    public Image fadeImage; // Referensi ke Image untuk animasi fade
    public float teleportCooldown = 2.0f; // Durasi cooldown setelah teleportasi

    public GameObject cam1;
    public GameObject cam2;

    private Transform player; // Referensi ke player
    private int currentDestinationIndex = 0; // Indeks tujuan saat ini dalam daftar
    private bool canTeleport = true; // Status apakah player bisa teleportasi
    private static bool isTeleporting = false; // Status global apakah teleportasi sedang berlangsung

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        fadeImage.color = new Color(0, 0, 0, 0); // Pastikan fadeImage transparan di awal
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && canTeleport && !isTeleporting)
        {
            StartCoroutine(Teleport());
        }
    }

    IEnumerator Teleport()
    {
        canTeleport = false; // Cegah teleportasi lebih lanjut selama proses ini
        isTeleporting = true; // Set status global teleportasi

        // Fade out
        yield return StartCoroutine(Fade(1.0f));

        // Teleport player ke tujuan berikutnya
        if (destinations.Length > 0)
        {
            player.position = destinations[currentDestinationIndex].position;
            currentDestinationIndex = (currentDestinationIndex + 1) % destinations.Length;

            cam1.SetActive(false);
            cam2.SetActive(true);
        }

        // Fade in
        yield return StartCoroutine(Fade(0.0f));

        // Tunggu selama durasi cooldown sebelum mengizinkan teleportasi lagi
        yield return new WaitForSeconds(teleportCooldown);
        canTeleport = true;
        isTeleporting = false; // Reset status global teleportasi
    }

    IEnumerator Fade(float targetAlpha)
    {
        float startAlpha = fadeImage.color.a;
        float elapsedTime = 0.0f;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / fadeDuration);
            fadeImage.color = new Color(0, 0, 0, alpha);
            yield return null;
        }

        fadeImage.color = new Color(0, 0, 0, targetAlpha);
    }
}
