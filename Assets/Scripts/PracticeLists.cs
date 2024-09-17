using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PracticeLists : MonoBehaviour
{
    [SerializeField]
    List<GameObject> _collecteditems = new List<GameObject>();

    [SerializeField]
    Transform _spawnPos;

    private GameObject _itemToSpawn;
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
        _collecteditems.Add(obj);
        obj.SetActive(false);
    }
    
    private void GenerateRandomItem()
    {
        if (_collecteditems.Count > 0)
        {
            _itemToSpawn = _collecteditems[Random.Range(0, _collecteditems.Count)];
            _itemToSpawn.transform.position = _spawnPos.transform.position;
            _itemToSpawn.SetActive(true);
        }
    }
}
