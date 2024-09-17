using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEditor;
using UnityEngine;

public class PracticeStacks : MonoBehaviour
{
    [SerializeField]
    Stack<GameObject> collectibles = new Stack<GameObject>();
    
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
        collectibles.Push(obj);
        obj.SetActive(false);

    }
    
    private void GenerateObject()

    {
        if(collectibles.Count > 0)
        {
            collectibles.Peek().gameObject.SetActive(true);
            collectibles.Pop();
        }
        
    }
}
