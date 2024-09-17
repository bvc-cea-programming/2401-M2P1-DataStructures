using UnityEngine;
using static UnityEditor.PlayerSettings;
using static UnityEngine.Rendering.DebugUI;

public class PracticeArrays : MonoBehaviour
{
    [SerializeField]
     GameObject[] enemyPerfabs;
    [SerializeField]
    GameObject originalPerfabs;
    private GameObject generateObject;
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
       if(originalPerfabs != null)
        {
            originalPerfabs.gameObject.SetActive(false);
        }
        if (generateObject != null) 
        {
            generateObject.SetActive(false);
        }

       GameObject perfabs = enemyPerfabs[Random.Range(0, enemyPerfabs.Length)];
       GameObject newGenerateObject = Instantiate(perfabs, originalPerfabs.transform.position, Quaternion.identity);
        generateObject = newGenerateObject;



    }
    
}
