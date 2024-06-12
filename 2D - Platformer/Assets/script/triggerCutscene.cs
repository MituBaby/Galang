using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class triggerCutscene : MonoBehaviour
{
    public GameObject Timeline;
    public GameObject Splash;

    private PlayerMovement playerMovement;
    private CharacterController2D characterController;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        characterController = GameObject.Find("Player").GetComponent<CharacterController2D>();
        animator = GameObject.Find("Player").GetComponent <Animator>();
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
            playerMovement.enabled = false;
            characterController.enabled = false;
            animator.SetFloat("Speed", 0);
        }
    }
    
    public void endCutscene()
    {
        playerMovement.enabled = true;
        characterController.enabled = true;
    }
}
