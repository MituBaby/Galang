using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource1 = GetComponent<AudioSource>();
        audioSource1 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetFloat("Speed") >= 1)
        {
            audioSource1.enabled = true;
        }

        if (animator.GetFloat("Speed") == 0)
        {
            audioSource1.enabled = false;
        }

        if (animator.GetBool("IsJump") == true)
        {
            audioSource2.enabled = true;
        }

        if (animator.GetBool("IsJump") == false)
        {
            audioSource2.enabled = false;
        }
    }
}
