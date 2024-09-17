using UnityEngine;

public class PracticeArrays : MonoBehaviour
{
    [SerializeField]
    GameObject[] enemyPrefabs;
    [SerializeField]
    GameObject spawnPosition;
    GameObject lastSpawned;
    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateRandomEnemy();
        }
    }
    
    private void GenerateRandomEnemy()
    {
        int rand = Random.Range(0,enemyPrefabs.Length);
        Destroy(lastSpawned);
        lastSpawned = Instantiate(enemyPrefabs[rand],spawnPosition.transform.position,Quaternion.identity);
    }
    
}
