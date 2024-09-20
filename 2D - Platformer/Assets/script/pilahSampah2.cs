using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pilahSampah2 : MonoBehaviour
{
    public GameObject triggerPilahSampah2;
    public GameObject featurePilahSampah2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        triggerPilahSampah2.SetActive(false);
        featurePilahSampah2.SetActive(true);
    }
}
