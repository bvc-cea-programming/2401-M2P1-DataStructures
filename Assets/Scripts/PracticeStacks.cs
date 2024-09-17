using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeStacks : MonoBehaviour
{
    private Stack<GameObject> items;
    private GameObject currentObject;
    private void Start()
    {
        items = new Stack<GameObject>();
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
          items.Push(obj);
          Debug.Log(items.Count);
    }
    
    private void GenerateObject()
    {
        Debug.Log("generate now");
      
        currentObject = items.Pop();
        currentObject.SetActive(true);
    }
}
