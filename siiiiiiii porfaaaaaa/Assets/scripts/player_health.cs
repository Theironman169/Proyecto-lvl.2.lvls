using UnityEngine;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    private int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("¡Jugador atacado! Vida restante: " + currentHealth);
        if (currentHealth <= 0)
        {
            Debug.Log("¡El jugador ha muerto!");
            // gameObject.SetActive(false);
        }
    }
}