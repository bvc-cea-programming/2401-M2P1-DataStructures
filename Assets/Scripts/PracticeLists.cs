using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

public class PracticeLists : MonoBehaviour
{
    [SerializeField]
    List<GameObject> collectibles = new List<GameObject>();
    [SerializeField]
    Transform _spawnLocation;
    
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
        collectibles.Add(obj);
        obj.SetActive(false);
    }
    
    private void GenerateRandomItem()
    {
        bool generateFromList = false;
        for(int i = 0; i < collectibles.Count; i++)
        {
            if (collectibles[i].gameObject.activeSelf == false)
            {
                generateFromList = true;
            }
        }
        if (generateFromList)
        {
            int randomPick = Random.Range(0, collectibles.Count);
            collectibles[randomPick].gameObject.SetActive(true);
            collectibles[randomPick] .gameObject.transform.position = _spawnLocation.transform.position;
        }
    }

    
}
