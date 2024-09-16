using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeStacks : MonoBehaviour
{
    Stack<GameObject> collectablesStack = new Stack<GameObject>();
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
        collectablesStack.Push(obj);
    }
    
    private void GenerateObject()
    {
        GameObject popedObject = collectablesStack.Pop();
        popedObject.SetActive(true);

    }
}
