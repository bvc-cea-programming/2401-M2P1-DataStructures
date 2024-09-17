using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeQueues : MonoBehaviour
{
    public Queue<GameObject> collectedObjects = new Queue<GameObject>();
    private void Start()
    {
        
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
        collectedObjects.Enqueue(obj);
    }
    
    private void GenerateObject()
    {
        if (collectedObjects.Count > 0)
        {
            GameObject firstItem = collectedObjects.Dequeue();
            firstItem.SetActive(true);
        }
    }
}
