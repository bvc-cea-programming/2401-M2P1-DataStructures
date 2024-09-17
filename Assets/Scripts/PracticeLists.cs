using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PracticeLists : MonoBehaviour
{
    [SerializeField]
    List<GameObject> collected = new List<GameObject>();
    [SerializeField]
    GameObject spawnPos;
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
        collected.Add(obj);
        obj.SetActive(false);
    }
    
    private void GenerateRandomItem()
    {
        bool doGenerate = false;
        for (int i = 0; i < collected.Count; i++)
        {
            if (collected[i].activeSelf == false)
            {
                doGenerate = true;
            }
        }
        if (doGenerate && collected.Count != 0)
        {
            int rand = Random.Range(0, collected.Count);
            collected[rand].gameObject.SetActive(true);
            collected[rand].gameObject.transform.position = spawnPos.transform.position;
        }
    }
}
