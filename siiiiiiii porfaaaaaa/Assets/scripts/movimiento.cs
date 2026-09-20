using UnityEditor.Tilemaps;
using UnityEngine;
public class MovementHorizontal : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    Animator AnimPlayer;
    SpriteRenderer RenderSprite;
    private Rigidbody2D rb;
    private float moveX;
    [SerializeField] private float jumpForce = 12f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    [SerializeField] private bool isGrounded;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        AnimPlayer = GetComponentInChildren<Animator>();
        RenderSprite = GetComponentInChildren<SpriteRenderer>();
    }
    private void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        salto();

    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveX * speed, rb.linearVelocity.y);

        if (moveX != 0)
        {
            AnimPlayer.SetFloat("Speed", Mathf.Abs(moveX));
        }
        else
        {
            AnimPlayer.SetFloat("Speed", 0);
        }

        if (moveX < 0)
        {
            RenderSprite.flipX = true;
        }
        else if (moveX > 0)
        {
            RenderSprite.flipX = false;
        }
    }
    private void salto()
    {
        isGrounded = Physics2D.OverlapCircle(
            groundCheck.position, 0.1f, groundLayer);
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.linearVelocity =
                new Vector2(rb.linearVelocity.x, jumpForce);
        }

    }
}
