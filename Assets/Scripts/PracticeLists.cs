using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PracticeLists : MonoBehaviour
{
    private GameObject randomObject;
    private GameObject lastObject;
    [SerializeField] private Transform spawnLotion;
    private List<GameObject> list;
    private int positionOffset;
    private void Start()
    {
        positionOffset = 1;
        list = new List<GameObject>();
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
        list.Add(obj);  
    }
    
    private void GenerateRandomItem()
    {
        if (lastObject != null)
        {
          
            lastObject.SetActive(false);
        }

        int index = Random.Range(0, list.Count);
       
        randomObject = list[index];
        
        if (randomObject.name == "Key Ring")
        {
            Debug.Log("offset");
            randomObject.transform.position = new Vector3(spawnLotion.position.x, spawnLotion.position.y + positionOffset, spawnLotion.position.z);
        }
        else
        {
            randomObject.transform.position = spawnLotion.position;
        }
        randomObject.SetActive(true);
        
     
        lastObject = randomObject;
    }
}
