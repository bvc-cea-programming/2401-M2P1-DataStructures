using UnityEngine;

public class PracticeArrays : MonoBehaviour
{
    [SerializeField]
    GameObject[] _skellies;
    [SerializeField]
    Transform _spawnPosition;
    GameObject _lastSpawned;
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
        int randomNum = Random.Range(0, _skellies.Length);
        _lastSpawned=Instantiate(_skellies[randomNum], _spawnPosition.transform.position, Quaternion.identity);
    }
    
}
