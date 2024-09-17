using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridObject : MonoBehaviour
{
    // Variable to hold the placed defense object
    public GameObject placedObject;

    // Method to set the defense object on this grid tile
    public void SetDefenseObject(GameObject defenseObject)
    {
        // Destroy any existing object on the tile
        if (placedObject != null)
        {
            Destroy(placedObject);
        }

        // Store the new defense object
        placedObject = defenseObject;

        // Store the new defense object
        placedObject = defenseObject;
    }
}
