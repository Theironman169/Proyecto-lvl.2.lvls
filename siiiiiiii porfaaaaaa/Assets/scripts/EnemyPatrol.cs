using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed = 2f;
    private int direction = 1;
    private Rigidbody2D rb;
    private SpriteRenderer sr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        rb.linearVelocity = new Vector2(direction * speed, rb.linearVelocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Flip();
        }
    }

    void Flip()
    {
        direction *= -1;
        sr.flipX = !sr.flipX;
    }
}