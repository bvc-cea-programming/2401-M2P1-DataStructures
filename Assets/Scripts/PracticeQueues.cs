using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeQueues : MonoBehaviour
{
    Queue<GameObject> collected = new Queue<GameObject>();
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
        collected.Enqueue(obj);
        obj.SetActive(false);
    }
    
    private void GenerateObject()
    {
        if(collected.Count != 0)
        {
            collected.Peek().gameObject.SetActive(true);
            collected.Dequeue();
        }
 
    }
}
