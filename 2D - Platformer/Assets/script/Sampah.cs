using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sampah : MonoBehaviour
{
    private bool isInRange = false;
    private PlayerMovement playerController;
    public float detectionRange = 2.0f;
    public GameObject interact;
    //public GameObject fade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Cari semua objek dengan tag "Player" di sekitar
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            /*Transform inter = interact.transform;
            inter.localScale = Vector3.one;*/
            float distance = Vector2.Distance(transform.position, player.transform.position);
            if (distance <= detectionRange)
            {
                interact.SetActive(true);
                playerController = player.GetComponent<PlayerMovement>();
                if (playerController != null)
                {
                    isInRange = true;
                }
            }
            else
            {
                isInRange = false;
                playerController = null;
                interact.SetActive(false);
            }

            if (Input.GetMouseButtonDown(0)) // 0 adalah tombol kiri mouse
            {
                Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                if (Vector2.Distance(mousePosition, transform.position) <= detectionRange)
                {
                    //fade.SetActive(false);
                    OnTrashClicked();
                }
            }
        }
        else
        {
            isInRange = false;
            playerController = null;
        }
    }

    private void OnTrashClicked()
    {
        Debug.Log("diklik");
        ///boxCollider.enabled = true;
        // Periksa apakah pemain berada dalam jangkauan dan tidak ada sampah yang menempel
        if (isInRange && playerController != null && playerController.attachedTrash == null)
        {
            Transform inter = interact.transform;
            inter.localScale = Vector3.zero;
            Debug.Log("periksa");
            playerController.AttachTrash(gameObject);
            Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Gambar lingkaran di Scene view untuk melihat jarak deteksi
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }
}
