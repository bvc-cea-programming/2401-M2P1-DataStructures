using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeStacks : MonoBehaviour
{
    // Stack to store collected objects
    private Stack<GameObject> collectedItems = new Stack<GameObject>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateObject();
        }
    }

    public void CollectObjects(GameObject obj)
    {
        // Add the object to the stack
        collectedItems.Push(obj);

        // Hide the object
        obj.SetActive(false);
    }
    
    private void GenerateObject()
    {
        // Check if there are any items in the stack
        if (collectedItems.Count > 0)
        {
            // Pop the last collected item from the stack
            GameObject lastCollectedItem = collectedItems.Pop();

            // Bring the item back
            lastCollectedItem.SetActive(true);
        }
    }
}
