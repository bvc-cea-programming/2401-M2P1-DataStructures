using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeQueues : MonoBehaviour
{
    Queue<GameObject> collectablesQueue = new Queue<GameObject>();
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
        collectablesQueue.Enqueue(obj);
    }

    private void GenerateObject()
    {
        GameObject popedObject = collectablesQueue.Dequeue();
        popedObject.SetActive(true);

    }
}
