using UnityEngine;
public class EnemyBase : MonoBehaviour
{
    // Variables públicas para cambiarlas fácilmente desde el Inspector
    public int life = 3;
    public int damage = 1;
    // Función que llamaremos cuando el jugador ataque a este enemigo
    public void TakeDamage(int cantidad)
    {
        life -= cantidad; // Restamos la vida

        // Comprobamos si el enemigo se quedó sin vida
        if (life <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        // Por ahora, simplemente desaparecemos al enemigo de la pantalla
        Destroy(gameObject);
    }
    // Usamos las colisiones físicas de Unity para lastimar al jugador
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Si el objeto con el que chocamos tiene la etiqueta "Player" (Jugador)
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("¡Enemigo tocó al jugador! " + damage + " de daño.");

            // Aquí le quitaríamos vida al jugador (dependerá de cómo programen a su jugador)
            // Ejemplo: collision.gameObject.GetComponent<PlayerScript>().RecibirDanio(danio);
        }
    }
}