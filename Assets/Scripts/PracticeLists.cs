using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PracticeLists : MonoBehaviour
{
    public Transform spawnPosition;
    private List<GameObject> collected = new List<GameObject>();
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
        collected.Add(obj);
    }
    
    private void GenerateRandomItem()
    {
        if (collected.Count > 0)
        {
            int randomIndex = Random.Range(0,collected.Count);
            GameObject objToSpawn = collected[randomIndex];
            objToSpawn.transform.position = spawnPosition.position;
            objToSpawn.SetActive(true);
        }
        
    }
}
