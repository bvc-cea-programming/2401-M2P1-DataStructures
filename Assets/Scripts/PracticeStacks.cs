using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeStacks : MonoBehaviour
{
    private Stack<GameObject> collectedObject = new Stack<GameObject>();
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
        collectedObject.Push(obj);
    }
    
    private void GenerateObject()
    {
        if (collectedObject.Count > 0)
        {
            GameObject lastItem = collectedObject.Pop();
            lastItem.SetActive(true);
        }
    }
}
