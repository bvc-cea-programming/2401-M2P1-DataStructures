using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PracticeLists : MonoBehaviour
{
    // List to store collected objects
    private List<GameObject> collectedItems = new List<GameObject>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateRandomItem();
        }
    }

    public void CollectObjects(GameObject obj)
    {
        // Add the object to the collected items list
        collectedItems.Add(obj);

        // Hide the object
        obj.SetActive(false);
    }
    
    private void GenerateRandomItem()
    {
        // Check if there are any items to generate
        if (collectedItems.Count > 0)
        {
            // Select a random item from the list
            int randomIndex = Random.Range(0, collectedItems.Count);

            // Reactive the randomly selected item
            GameObject randomItem = collectedItems[randomIndex];
            randomItem.SetActive(true);

            // Remove it from the collected items list
            collectedItems.RemoveAt(randomIndex);
        }
    }
}
