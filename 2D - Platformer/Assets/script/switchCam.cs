using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCam : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}
