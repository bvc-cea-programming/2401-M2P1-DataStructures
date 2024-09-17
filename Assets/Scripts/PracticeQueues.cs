using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeQueues : MonoBehaviour
{
    Queue<GameObject> _collect = new Queue<GameObject>();
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
        _collect.Enqueue(obj);
        obj.SetActive(false);
    }
    
    private void GenerateObject()
    {
        if (_collect.Count > 0)
        {
            _collect.Peek().gameObject.SetActive(true);
            _collect.Dequeue();
        }
    }
}
