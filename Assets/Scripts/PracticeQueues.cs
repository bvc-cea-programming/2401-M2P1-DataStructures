using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeQueues : MonoBehaviour
{

    Queue<GameObject> _collectibles = new Queue<GameObject>();
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
        _collectibles.Enqueue(obj);
        obj.SetActive(false);
    }
    
    private void GenerateObject()
    {
        if(_collectibles.Count > 0)
        {
            _collectibles.Peek().gameObject.SetActive(true);
            _collectibles.Dequeue().gameObject.SetActive(true);
        }
    }
}
