using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PracticeLists : MonoBehaviour
{
    private GameObject randomObject;
    private GameObject lastObject;
    [SerializeField] private Transform spawnLotion;
    private void Start()
    {
      
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateRandomItem();
        }
    }

    public void CollectObjects(GameObject obj)
    {
        obj.SetActive(false);
        //list.Add(new GameObject(obj);
        List<GameObject> list = new List<GameObject>();
        list.Add(obj);
        GameObject perfabs = list[Random.Range(0, list.Count)];
        randomObject = perfabs;
       
    }
    
    private void GenerateRandomItem()
    {
       
        if (lastObject != null)
        {
            Debug.Log("randomObject is" + lastObject);
            lastObject.SetActive(false);
        }
        GameObject clone =Instantiate(randomObject, spawnLotion.position, Quaternion.identity);
        clone.SetActive(true);
        lastObject = clone;
    }
}
