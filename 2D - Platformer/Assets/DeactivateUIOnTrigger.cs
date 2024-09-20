using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Tambahkan ini untuk mengakses UI
using TMPro;

public class DeactivateUIOnTrigger : MonoBehaviour
{
    // Objek UI yang akan diatur menjadi tidak aktif
    public GameObject uiObject;
    public TextMeshProUGUI uiText;

    // Fungsi ini akan dipanggil ketika ada objek lain memasuki area trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Periksa apakah objek UI diatur
        if (uiObject != null)
        {
            // Set objek UI menjadi tidak aktif
            uiObject.SetActive(false);
            Destroy(uiText);
        }
        else
        {
            Debug.LogWarning("UI Object is not set in the inspector.");
        }
    }
}

