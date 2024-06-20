using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloodMovement : MonoBehaviour
{
    public float speed = 2.0f; // Kecepatan gerak banjir
    public Vector2 floodStartPos; // Titik awal banjir
    public GameObject player; // Referensi ke objek player
    public Vector2 playerStartPos; // Titik awal player

    void Start()
    {
        // Simpan posisi awal banjir dan player
        floodStartPos = transform.position;
        playerStartPos = player.transform.position;
    }

    void Update()
    {
        // Gerakan banjir ke atas
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Cek apakah objek banjir bertabrakan dengan player
        if (collision.gameObject == player)
        {
            // Kembalikan player dan banjir ke posisi awal
            player.transform.position = playerStartPos;
            transform.position = floodStartPos;
        }
    }
}
