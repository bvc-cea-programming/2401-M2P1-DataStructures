using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;


public class GridManager : MonoBehaviour
{
    [SerializeField] private int gridSize = 10;
    [SerializeField] private Vector2 gridOffset = new Vector2(0.5f, 0.5f);
    [SerializeField] private GameObject baseGridPrefab;
    
    [SerializeField] private List<DefenseObjectSO> defenseObjects = new List<DefenseObjectSO>();
    
    private GridObject[,] _grid;

    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        _grid = new GridObject[gridSize, gridSize];

        for(int x=0; x<gridSize;x++)
        {
            for(int y=0;y<gridSize; y++)
            {

                GameObject obj = Instantiate(baseGridPrefab);
                Instantiate(baseGridPrefab,new Vector3(x + gridOffset.x, 0 ,y+gridOffset.y),Quaternion.identity);

                _grid[x,y] = obj.GetComponent<GridObject>(); 

            }
        }
    }

    public GridObject GetGridObject(int x, int y)
    {
        return _grid[x, y];
    }
    
    public void SetGridObject(int x, int y, GridObject gridObject)
    {
        
    }

    public void SetGridObject(int x, int y)
    {
        if (x < 0 || y < 0 || x >= gridSize || y >= gridSize) return;

        Destroy(_grid[x, y].gameObject);

        var RandomObj = defenseObjects[Random.Range(0, defenseObjects.Count)].objectprefab;
         

        GameObject obj = Instantiate(RandomObj, new Vector3(x + gridOffset.x, 0, y + gridOffset.y), Quaternion.identity);
        _grid[x, y] = obj.GetComponent<GridObject>();
    }
}
