using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class triggerCutscene : MonoBehaviour
{
    public GameObject Timeline;

    private PlayerMovement playerMovement;
    private CharacterController2D characterController;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        characterController = GameObject.Find("Player").GetComponent<CharacterController2D>();
        animator = GameObject.Find("Player").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Timeline.SetActive(true);
            playerMovement.enabled = false;
            characterController.enabled = false;
            animator.SetFloat("Speed", 0);
            animator.SetBool("isCrouch", false);
        }
    }
    
    /*public void endCutscene()
    {
        playerMovement.enabled = true;
        characterController.enabled = true;
    }*/
}
