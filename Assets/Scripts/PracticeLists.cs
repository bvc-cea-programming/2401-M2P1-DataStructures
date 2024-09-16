using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PracticeLists : MonoBehaviour
{
    List<GameObject> collectables = new List<GameObject>();
    private GameObject _collectableInstance;

    [SerializeField] private GameObject spawnLocationObject;

    private int randomNum;
    private Vector3 spawnLocation;

    private void Start()
    {
        spawnLocation = spawnLocationObject.transform.position;
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
        obj.SetActive(false);
        collectables.Add(obj);
    }
    
    private void GenerateRandomItem()
    {
        if (_collectableInstance != null)
        {
            Destroy(_collectableInstance);
        }
        randomNum = Random.Range(0, collectables.Count);
        _collectableInstance = Instantiate(collectables[randomNum], new Vector3(spawnLocation.x, collectables[randomNum].transform.position.y, spawnLocation.z), Quaternion.identity);
        _collectableInstance.SetActive(true);
    }
}
