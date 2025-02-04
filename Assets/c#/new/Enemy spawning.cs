using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawning : MonoBehaviour
{
    public GameObject objectToSpawn; // The prefab to spawn
    public Transform spawnPoint; // The point where objects will be spawned
    float spawnInterval = 10f; // Time between spawns in seconds
    float minimumSpawnInterval = 1f; // The minimal amount of time between enemies spawning.
    float intervalDecrease = 8.1F; // How much does the spawn time decrease by.

    private void Start()
    {
          StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            if (objectToSpawn != null & spawnPoint != null)
            {
                Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
            }
            
            else
            {
                Debug.LogWarning("Object to spawn or spawn point is not set.");
            }
            
            //Wait between spawn times
            yield return new WaitForSeconds(spawnInterval);
            //calculate the new spamn time.
            spawnInterval = Mathf.Max(minimumSpawnInterval, spawnInterval - intervalDecrease);
        }
    }
}
