using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
    public GameObject door; // Objek pintu yang akan diatur
    public float doorMoveSpeed = 2f; // Kecepatan gerakan pintu
    public float targetYPosition; // Posisi Y target pintu saat turun
    public float targetYPlusPosition;
    private bool isPlayerOnButton = false; // Status apakah player menabrak tombol

    void Update()
    {
        if (isPlayerOnButton)
        {
            if (door.transform.position.y < targetYPlusPosition)
            {
                Debug.Log("door control " + door.transform.position.y);
                // Pintu naik saat player menabrak tombol
                door.transform.position += new Vector3(0, doorMoveSpeed * Time.deltaTime, 0);
                Debug.Log("Player is on button: Door is moving up");
            }

        }
        else
        {
            // Pintu turun hingga mencapai targetYPosition
            if (door.transform.position.y > targetYPosition)
            {
                door.transform.position -= new Vector3(0, doorMoveSpeed * Time.deltaTime, 0);
                Debug.Log("Player is not on button: Door is moving down");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerOnButton = true;
            Debug.Log("Player entered the button trigger");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerOnButton = false;
            Debug.Log("Player exited the button trigger");
        }
    }
}
