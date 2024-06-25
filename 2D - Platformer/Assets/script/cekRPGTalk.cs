using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cekRPGTalk : MonoBehaviour
{
    public GameObject canvasRPGTalk;
    public GameObject RPGTalk;
    public GameObject triggerDialog;

    private PlayerMovement playerMovement;
    private CharacterController2D characterController;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        characterController = GameObject.Find("Player").GetComponent<CharacterController2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!canvasRPGTalk.activeInHierarchy)
        {
            playerMovement.enabled = true;
            characterController.enabled = true;
            triggerDialog.SetActive(true);
            Destroy(RPGTalk);
        }
    }
}
