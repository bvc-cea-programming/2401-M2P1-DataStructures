using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class PracticeQueues : MonoBehaviour
{
    private GameObject generateItem;
    private GameObject lastItem;
    private int itemsCount;
   private Queue<GameObject> items;
    private void Start()
    {
        items = new Queue<GameObject>();
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
        items.Enqueue(obj);
     
    }

    private void GenerateObject()
    {
        generateItem = items.Dequeue();
        generateItem.SetActive(true);

    }
}
