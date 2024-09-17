using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeQueues : MonoBehaviour
{
    private Queue<GameObject> collectibleQueue;
    private GameObject currentPrefab;
    private void Start()
    {
        collectibleQueue = new Queue<GameObject>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateObject();
        }
    }

    public void CollectObjects(GameObject obj)
    {
        obj.SetActive(false);
        collectibleQueue.Enqueue(obj);
        Debug.Log(collectibleQueue.Count);
    }
    
    private void GenerateObject()
    {
        if(collectibleQueue.Count != 0)
        {
            int queueCount = collectibleQueue.Count;
            currentPrefab = collectibleQueue.Dequeue();
            currentPrefab.SetActive(true);
            Debug.Log(collectibleQueue.Count);
        }
    }
}
