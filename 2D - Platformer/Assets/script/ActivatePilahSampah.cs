using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePilahSampah : MonoBehaviour
{
    public GameObject triggerPilahSampah3;
    public GameObject canvasDialog;
    public GameObject featurePilahSampah;
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
        if (canvasDialog == null)
        {
            featurePilahSampah.SetActive(true);
            triggerPilahSampah3.SetActive(false);
        }
    }
}
