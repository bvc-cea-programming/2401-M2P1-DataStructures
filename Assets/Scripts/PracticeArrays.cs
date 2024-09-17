using UnityEngine;

public class PracticeArrays : MonoBehaviour
{
    [SerializeField]
    GameObject[] _enemyObjects;
    [SerializeField]
    Transform _spawnPoint;
    private GameObject _spawnedEnemy;

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
        Destroy(_spawnedEnemy);
        _spawnedEnemy = Instantiate(_enemyObjects[Random.Range(0, _enemyObjects.Length)], _spawnPoint.transform.position, Quaternion.identity);      
    }    
}
