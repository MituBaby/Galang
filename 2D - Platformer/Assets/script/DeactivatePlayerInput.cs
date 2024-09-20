using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivatePlayerInput : MonoBehaviour
{
    public GameObject featurePilahSampah;
    public GameObject canvasPilahSampah;
    private PlayerMovement playerMovement;
    private CharacterController2D characterController;
    private Animator animator;
    private Transform child;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        characterController = GameObject.Find("Player").GetComponent<CharacterController2D>();
        animator = GameObject.Find("Player").GetComponent<Animator>();

        if (canvasPilahSampah != null)
        {
            child = canvasPilahSampah.transform.Find("featurePilahSampah");
            if (child == null)
            {
                playerMovement.enabled = true;
                characterController.enabled = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (featurePilahSampah.activeInHierarchy)
        {
            playerMovement.enabled = false;
            characterController.enabled = false;
            animator.SetFloat("Speed", 0);
        }

        if (child == null)
        {
            playerMovement.enabled = true;
            characterController.enabled = true;
        }
    }
}
