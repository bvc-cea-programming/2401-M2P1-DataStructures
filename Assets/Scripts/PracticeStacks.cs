using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeStacks : MonoBehaviour
{
    Stack<GameObject> _collect = new Stack<GameObject>();
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
        _collect.Push(obj);
        obj.SetActive(false);
    }
    
    private void GenerateObject()
    {
        if (_collect.Count > 0)
        {
            _collect.Peek().gameObject.SetActive(true);
            _collect.Pop();
        }
    }
}
