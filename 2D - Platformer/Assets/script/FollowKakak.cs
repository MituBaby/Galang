using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FollowKakak : MonoBehaviour
{
    public float speed;
    public float distance;
    public float jumpPower;
    public Transform player;
    public Transform spawn;
    Animator anim;
    Rigidbody2D rig;
    public LayerMask groundLayer;
    public float teldistance;

    public ParticleSystem tel;

    public bool isFacingRight = true;

    public float detectionRange = 5f; // Jarak untuk mendeteksi player
    public LayerMask playerLayer; // Layer yang dianggap sebagai player

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player").transform;
        Physics2D.IgnoreLayerCollision(6, 10);
    }

    void FixedUpdate()
    {
        float distanceToPlayer = Mathf.Abs(transform.position.x - player.position.x);

        if (distanceToPlayer > distance)
        {
            Follow();
        }
        else
        {
            anim.SetFloat("Speed", 0f);
        }

        if (Vector2.Distance(player.position, transform.position) > teldistance)
        {
            Spawn();
            //tel.gameObject.SetActive(true);
            //tel.Play();
        }
        //if (!tel.isPlaying)
        //{
        //    tel.gameObject.SetActive(false);
        //}

        FacePlayer();
    }

    public void Spawn()
    {
        transform.position = spawn.position;
    }

    void Follow()
    {
        Vector2 direction = new Vector2(player.position.x - transform.position.x, 0).normalized;
        transform.Translate(direction * speed * Time.deltaTime);
        anim.SetFloat("Speed", Mathf.Abs(direction.x));

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, 0.5f, groundLayer);
        RaycastHit2D hitdia = Physics2D.Raycast(transform.position, new Vector2(direction.x, 1), 3f, groundLayer);

        if (spawn.position.y - transform.position.y <= 0)
            hitdia = new RaycastHit2D();

        if (hit || hitdia)
        {
            rig.velocity = new Vector2(rig.velocity.x, jumpPower);
            anim.SetBool("IsJump", true);
        }
        else
        {
            anim.SetBool("IsJump", false);
        }
    }

    public void FacePlayer()
    {
        if (player.position.x > transform.position.x && !isFacingRight)
        {
            Flip();
        }
        else if (player.position.x < transform.position.x && isFacingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
