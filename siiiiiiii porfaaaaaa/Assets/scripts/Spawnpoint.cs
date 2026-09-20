using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public string spawnPointID;

    private void Start()
    {
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