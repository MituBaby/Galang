using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cekSampah : MonoBehaviour
{
    public GameObject sampah1, sampah2, sampah3, sampah4, sampah5, sampah6, sampah7;
    public GameObject pilahSampah;
    //private GameObject fade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //fade = GameObject.Find("Fade");
        if (!sampah1 && !sampah2 && !sampah3 && !sampah4 && !sampah5 && !sampah6 && !sampah7)
        {
            //fade.SetActive(true);
            Destroy(pilahSampah);
            Time.timeScale = 1;
        }
    }
}
