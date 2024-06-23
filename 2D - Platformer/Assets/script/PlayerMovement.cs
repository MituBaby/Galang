using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D characterController;
    public Animator animator;

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    public GameObject attachedTrash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump") && !crouch)
        {
            jump = true;
            //animator.SetBool("IsJump", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }


    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouch", isCrouching);
    }

    public void OnLanding()
    {
        animator.SetBool("IsJump", false);
    }

    void FixedUpdate()
    {
        characterController.Move(horizontalMove * Time.deltaTime, crouch, jump);
        jump = false;
    }

    public void AttachTrash(GameObject trash)
    {
        if (attachedTrash == null)
        {
            attachedTrash = trash;

            // Tambahkan FixedJoint2D ke pemain dan hubungkan dengan sampah
            FixedJoint2D joint = gameObject.AddComponent<FixedJoint2D>();
            joint.connectedBody = trash.GetComponent<Rigidbody2D>();
            joint.autoConfigureConnectedAnchor = false;
            joint.anchor = Vector2.zero;
            joint.connectedAnchor = Vector2.zero;
        }
    }
}
