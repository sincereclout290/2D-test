using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDestroywhenallaredead : MonoBehaviour
{
   public GameObject door; // Assign the door in the inspector
    public  List<GameObject> enemies = new List<GameObject>();

    void Start()
    {
        GameObject[] allEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in allEnemies)
        {
            enemies.Add(enemy);
            Debug.Log("Enemies added");
        }
    }

    public void EnemyDied(GameObject deadEnemy)
    {
        enemies.Remove(deadEnemy);
        enemies.TrimExcess();

        if (AreAllEnemiesDead())
        {
            Destroy(door); // Destroy the door
            Debug.Log("Door is now destroyed");
        }
    }

    private bool AreAllEnemiesDead()
    {
        return enemies.Count == 0;
    }
}