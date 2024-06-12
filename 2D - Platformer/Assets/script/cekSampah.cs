using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cekSampah : MonoBehaviour
{
    public GameObject sampah1, sampah2, sampah3;
    public GameObject pilahSampah;
    public GameObject triggerPilahSAmpah;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!sampah1 && !sampah2 && !sampah3)
        {
            pilahSampah.SetActive(false);
            triggerPilahSAmpah.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
