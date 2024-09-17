using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeQueues : MonoBehaviour
{
    // Queue to store collected objects
    private Queue<GameObject> collectedItems = new Queue<GameObject>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateObject();
        }
    }

    public void CollectObjects(GameObject obj)
    {
        // Add the object to the queue
        collectedItems.Enqueue(obj);

        // Hide the object
        obj.SetActive(false);
    }
    
    private void GenerateObject()
    {
        // Check if there are any items in the queue
        if (collectedItems.Count > 0)
        {
            // Dequeue the first collected item from the queue
            GameObject firstCollectedItem = collectedItems.Dequeue();

            // Bring the item back
            firstCollectedItem.SetActive(true);
        }
    }
}
