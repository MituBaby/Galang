using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class triggerCutscene : MonoBehaviour
{
    public GameObject Timeline;
    public GameObject Splash;

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
        if (collision.gameObject.tag == "Player")
        {
            Timeline.SetActive(true);
            Splash.SetActive(true);
        }
    }
    

}
