using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeStacks : MonoBehaviour
{
    private Stack<GameObject> collectibleStack;
    private GameObject currentPrefab;
    private void Start()
    {
        collectibleStack = new Stack<GameObject>();
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
        collectibleStack.Push(obj);
        Debug.Log(collectibleStack.Count);
    }
    
    private void GenerateObject()
    {
        if(collectibleStack.Count != 0)
        {
            int stackCount = collectibleStack.Count;
            currentPrefab = collectibleStack.Pop();
            currentPrefab.SetActive(true);
            Debug.Log(collectibleStack.Count);
        }

        
    }
}
