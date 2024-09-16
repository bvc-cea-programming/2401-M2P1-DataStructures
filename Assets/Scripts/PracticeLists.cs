using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class PracticeLists : MonoBehaviour
{
    public Transform spawner;
    public List<GameObject> ItemsCollected = new List<GameObject>();
    public GameObject currentItemSpawned; 

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
        ItemsCollected.Add(obj);
        obj.SetActive(false);

    }
    
    private void GenerateRandomItem()
    {
        if (currentItemSpawned != null) // just checking
        {

            currentItemSpawned.SetActive(false);

        }

        int randomIndex = Random.Range(0, ItemsCollected.Count); // randomly pick items
        GameObject randomItem = ItemsCollected[randomIndex];

        randomItem.transform.position = spawner.position; // randomly move to spawner
        randomItem.SetActive(true);

        currentItemSpawned = randomItem;

    }
}
