using UnityEngine;

public class PracticeArrays : MonoBehaviour
{
    // Array to hold enemy prefabs
    [SerializeField] private GameObject[] enemyPrefabs;

    // Variable to keep track of the currently spawned enemy
    private GameObject currentEnemy;

    // Define a spawn point
    [SerializeField] private Transform spawnPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateRandomEnemy();
        }
    }

    private void GenerateRandomEnemy()
    {
        // If there's a current enemy, destroy it before spawning a new one
        if (currentEnemy != null)
        {
            Destroy(currentEnemy);
        }

        // Randomly select an enemy from the array
        int randomIndex = Random.Range(0, enemyPrefabs.Length);

        // Instantiate the randomly selected enemy at the spawn point
        currentEnemy = Instantiate(enemyPrefabs[randomIndex], spawnPoint.position, spawnPoint.rotation);
    }
}
