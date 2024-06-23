using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject door; // Objek pintu yang akan diatur
    public GameObject tombol1;
    public GameObject tombol2;
    public float doorMoveSpeed = 2f; // Kecepatan gerakan pintu
    public float targetYPosition = 2f; // Posisi Y target pintu saat turun

    private bool isPlayerOnTrigger = false; // Status apakah player menabrak trigger

    void Start()
    {
        // Pastikan pintu langsung turun saat game dimulai
        //isPlayerOnTrigger = true;
    }

    void Update()
    {
        if (isPlayerOnTrigger && door.transform.position.y > targetYPosition)
        {
            // Pintu turun
            door.transform.position -= new Vector3(0, doorMoveSpeed * Time.deltaTime, 0);
        }

        // Disable trigger dan aktifkan tombol jika pintu sudah mencapai targetYPosition
        if (door.transform.position.y <= targetYPosition)
        {
            gameObject.SetActive(false);
            tombol1.SetActive(true);
            tombol2.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerOnTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerOnTrigger = false;
        }
    }
}
