using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public string targetSpawnPointID;
    public string nombreDelNivel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.nextSpawnPointID = targetSpawnPointID;
            SceneManager.LoadScene(nombreDelNivel);
        }
    }
}