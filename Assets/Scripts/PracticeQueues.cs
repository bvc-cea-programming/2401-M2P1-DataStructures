using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeQueues : MonoBehaviour
{
    [SerializeField]
    Queue<GameObject> collectibles = new Queue<GameObject>();
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
        collectibles.Enqueue(obj);
        obj.SetActive(false);
    }
    
    private void GenerateObject()
    {
        if (collectibles.Count > 0)
        {
            collectibles.Peek().gameObject.SetActive(true);
            collectibles.Dequeue();
        }
    }
}
