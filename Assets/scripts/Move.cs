using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpPow = 10f;
    [SerializeField] private LayerMask GroundLayer;
    [SerializeField] private Transform GroundCheck;
    private Animator ani;
    private float moveInput;
    private bool Right = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveHandle();
        jumpHandle();
        changeAnimation();
    }

    private void FixedUpdate()
    {
        

    }

    public void moveHandle()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (moveInput < 0 && Right || moveInput > 0 && !Right)
        {
            Right = !Right;
            Vector3 sc = transform.localScale;
            sc.x *= -1;
            transform.localScale = sc;
        }
    }

    public bool Grounded()
    {
        bool grounded = Physics2D.OverlapCircle(GroundCheck.position, 0.5f, GroundLayer);

        return grounded;
    }

    public void jumpHandle()
    {

        if (Grounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPow);

        }
    }

    public void changeAnimation()
    {
        bool isRunning = Mathf.Abs(rb.velocity.x) > 0.1f;
        bool isJumping = !Grounded();
        ani.SetBool("Running", isRunning);
        ani.SetBool("Jumping", isJumping);

    }

}
