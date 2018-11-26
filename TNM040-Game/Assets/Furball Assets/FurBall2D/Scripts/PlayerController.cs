
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{

    public  float WaterSpeed = 0;
    public  float WaterJumpForce = 0;
    public  float GroundSpeed = 0;
    public  float GroundJumpForce = 0;
    public float maxSpeed = 6f;
    public float jumpForce = 1000f;
    public Transform groundCheck;
    public LayerMask whatIsGround;
    public float verticalSpeed = 20;
    [HideInInspector]
    public bool lookingRight = true;
    bool doubleJump = false;
    public GameObject Boost;

    private Animator cloudanim;
    public GameObject Cloud;
    public bool canJump = false;
    public bool canDown = false;
    public bool canLeft = false;
    public bool canRight = true;

    private Rigidbody2D rb2d;
    private Animator anim;
    private bool isGrounded = false;


    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        //cloudanim = GetComponent<Animator>();

        Cloud = GameObject.Find("Cloud");

        //cloudanim = GameObject.Find("Cloud(Clone)").GetComponent<Animator>();
    }


    void OnCollisionEnter2D(Collision2D collision2D)
    {

        if (collision2D.relativeVelocity.magnitude > 20)
        {
            Boost = Instantiate(Resources.Load("Prefabs/Cloud"), transform.position, transform.rotation) as GameObject;
            //	cloudanim.Play("cloud");	

        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Water"))
        {
            rb2d.gravityScale = 0.2f;
            maxSpeed = WaterSpeed;
            jumpForce = WaterJumpForce;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Water"))
        {
            rb2d.gravityScale = 1f;
            maxSpeed = GroundSpeed;
            jumpForce = GroundJumpForce;
        }
    }
    
    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump") && (isGrounded || !doubleJump) && canJump)
        {
            rb2d.AddForce(new Vector2(0, jumpForce));

            if (!doubleJump && !isGrounded)
            {
                doubleJump = true;
                Boost = Instantiate(Resources.Load("Prefabs/Cloud"), transform.position, transform.rotation) as GameObject;
                //	cloudanim.Play("cloud");		
                FindObjectOfType<AudioManager>().Play("jump");
            }
            FindObjectOfType<AudioManager>().Play("jump");

        }


        if (Input.GetButtonDown("Vertical") && !isGrounded && canDown)
        {
            rb2d.AddForce(new Vector2(0, -jumpForce));
            Boost = Instantiate(Resources.Load("Prefabs/Cloud"), transform.position, transform.rotation) as GameObject;
            //cloudanim.Play("cloud");
        }

    }


    void FixedUpdate()
    {
        if (isGrounded)
            doubleJump = false;

        float hor;

        hor = Input.GetAxis("Horizontal");



        anim.SetFloat("Speed", Mathf.Abs(hor));

        rb2d.velocity = new Vector2(hor * maxSpeed, rb2d.velocity.y);


        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.15F, whatIsGround);

        anim.SetBool("IsGrounded", isGrounded);

        if ((hor > 0 && !lookingRight) || (hor < 0 && lookingRight))
            Flip();

        anim.SetFloat("vSpeed", GetComponent<Rigidbody2D>().velocity.y);
    }



    public void Flip()
    {
        lookingRight = !lookingRight;
        Vector3 myScale = transform.localScale;
        myScale.x *= -1;
        transform.localScale = myScale;
    }

}








