using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform respawnPoint;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            transform.position = respawnPoint.position;
        }
    }
}
