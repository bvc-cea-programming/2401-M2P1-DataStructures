using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeStacks : MonoBehaviour
{
    Stack<GameObject> _collectibles = new Stack<GameObject>();
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
        _collectibles.Push(obj);
        obj.SetActive(false);
    }
    
    private void GenerateObject()
    {
        if(_collectibles.Count > 0)
        {
            _collectibles.Peek().gameObject.SetActive(true);
            _collectibles.Pop();
        }
    }
}
