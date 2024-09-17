using UnityEngine;

public class PracticeArrays : MonoBehaviour
{
    [SerializeField]
    GameObject[] _enemyPrefab;

    [SerializeField]
    Transform _spawnPos;

    private GameObject _lastSpawned;

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
        Destroy(_lastSpawned);
        _lastSpawned = Instantiate(_enemyPrefab[Random.Range(0, _enemyPrefab.Length)], _spawnPos.transform.position, Quaternion.identity);
    }
    
}
