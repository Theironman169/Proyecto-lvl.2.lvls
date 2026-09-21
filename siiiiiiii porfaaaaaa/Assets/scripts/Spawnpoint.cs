using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public string spawnPointID;

    private void Start()
    {
        // Comprueba si este punto de aparición coincide con el ID solicitado
        if (GameManager.nextSpawnPointID == spawnPointID)
        {
            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                player.transform.position = transform.position;
            }
        }
    }
}