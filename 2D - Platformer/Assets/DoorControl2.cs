using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl2 : MonoBehaviour
{
    public GameObject tombol;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Sister"))
        {
            tombol.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
