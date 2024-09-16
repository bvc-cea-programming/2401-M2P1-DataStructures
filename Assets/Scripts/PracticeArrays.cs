using UnityEngine;

public class PracticeArrays : MonoBehaviour
{
    [SerializeField] private GameObject _skeletonInstance;
    [SerializeField] private GameObject[] skeletonPrefabs;
    private Vector3 spawnLocation;
    private int randomNum;
    private void Start()
    {
        spawnLocation = _skeletonInstance.transform.localPosition;
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
        if (_skeletonInstance != null)
        {
            Destroy(_skeletonInstance);
        }
        randomNum = Random.Range(0, skeletonPrefabs.Length);
        _skeletonInstance = Instantiate(skeletonPrefabs[randomNum], spawnLocation, Quaternion.identity);
    }
    
}
