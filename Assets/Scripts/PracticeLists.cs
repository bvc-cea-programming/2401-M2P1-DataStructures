using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PracticeLists : MonoBehaviour
{
    [SerializeField]
    List<GameObject> _collectibles;
    [SerializeField]
    Transform _spawnPoint;
    private GameObject _spawnedItem;
    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateRandomItem();
        }
    }

    public void CollectObjects(GameObject obj)
    {
        _collectibles.Add(obj);
        obj.SetActive(false);
    }
    
    private void GenerateRandomItem()
    {
        if (_collectibles.Count > 0)
        {
            _spawnedItem = _collectibles[Random.Range(0, _collectibles.Count)];
            _spawnedItem.transform.position = _spawnPoint.transform.position;
            _spawnedItem.SetActive(true);
        }
    }
}
