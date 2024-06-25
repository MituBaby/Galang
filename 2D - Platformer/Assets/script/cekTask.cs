using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cekTask : MonoBehaviour
{
    public GameObject canTeleport;
    private GameObject sampah1;
    private GameObject sampah2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sampah1 = GameObject.Find("sampah1");
        sampah2 = GameObject.Find("sampah2");
        if (sampah1 == null && sampah2 == null)
        {
            canTeleport.SetActive(false);
        }
    }
}
