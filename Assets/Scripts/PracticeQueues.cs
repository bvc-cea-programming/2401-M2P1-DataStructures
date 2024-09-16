using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeQueues : MonoBehaviour
{
    private Queue<GameObject> collectedQueue = new Queue<GameObject>();
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
        collectedQueue.Enqueue(obj);
        obj.SetActive(false);
    }
    
    private void GenerateObject()
    {
        if (collectedQueue.Count > 0)
        {
            GameObject firstCollectedObject = collectedQueue.Dequeue(); //https://discussions.unity.com/t/issue-with-gameobjects-and-enqueue/183607
            firstCollectedObject.SetActive(true);
        }
        
    }

}
