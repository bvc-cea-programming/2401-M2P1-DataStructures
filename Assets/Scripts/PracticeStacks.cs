using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeStacks : MonoBehaviour
{
    private Stack<GameObject> collectedStack = new Stack<GameObject>();

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
        collectedStack.Push(obj);
        obj.SetActive(false);
    }
    
    private void GenerateObject() //just to show from the last object right?
    {
        if (collectedStack.Count > 0)
        {
            GameObject lastCollectedObject = collectedStack.Pop(); 
            lastCollectedObject.SetActive(true);
        }
    }
}
