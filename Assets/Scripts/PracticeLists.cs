using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PracticeLists : MonoBehaviour
{
    [SerializeField] private List<GameObject> collectibleList;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject collectiblePrefab;
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
        obj.SetActive(false);
        collectibleList.Add(obj);
    }
    
    private void GenerateRandomItem()
    {
        
        if(collectiblePrefab != null)
        {
            collectiblePrefab.SetActive(false);
        }

        int collectibleCount = collectibleList.Count;
        int randomSpawn = Random.Range(0, collectibleCount);
        collectiblePrefab = collectibleList[randomSpawn];
        collectiblePrefab.transform.position = new Vector3(spawnPoint.position.x, collectibleList[randomSpawn].transform.position.y, spawnPoint.position.z);
        collectiblePrefab.SetActive(true);
    }
}
