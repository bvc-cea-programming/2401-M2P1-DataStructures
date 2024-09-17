using UnityEngine;

public class PracticeArrays : MonoBehaviour
{
    public GameObject[] Skeleton_MagePrefab;
    public Transform Spawnpoint;
    public GameObject CurrentEnemy;
    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (CurrentEnemy != null)
            {
                Destroy(CurrentEnemy);
            }
            GenerateRandomEnemy();
            
        }
    }
    
    private void GenerateRandomEnemy()
    {
        int randomIndex = Random.Range(0, Skeleton_MagePrefab.Length);
        GameObject randomEnemy = Skeleton_MagePrefab[randomIndex];
        CurrentEnemy = Instantiate(randomEnemy, Spawnpoint.position, Spawnpoint.rotation);
       
    }
    
}
