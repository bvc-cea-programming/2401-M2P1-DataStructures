using UnityEngine;

public class PracticeArrays : MonoBehaviour
{
    [SerializeField] private GameObject[] SkeletonPrefabs;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject spawnSkeleton;

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
        int randomSkeleton = Random.Range(0, SkeletonPrefabs.Length);

        if(spawnSkeleton != null)
        {
            Destroy(spawnSkeleton);
            spawnSkeleton = Instantiate(SkeletonPrefabs[randomSkeleton], spawnPoint.position, Quaternion.identity);
        }
        else
        {
            spawnSkeleton = Instantiate(SkeletonPrefabs[randomSkeleton], spawnPoint.position, Quaternion.identity);
        }
            
        
    }
    
}
