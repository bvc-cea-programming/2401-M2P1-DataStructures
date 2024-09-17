
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int gridSize = 10;
    [SerializeField] private Vector2 gridOffset = new Vector2(0.5f, 0.5f);
    [SerializeField] private GameObject baseGridPrefab;
    
    [SerializeField] private List<DefenseObjectSO> defenseObjects = new List<DefenseObjectSO>();
    
    private GridObject[,] _grid = new GridObject[10,10];

    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        for (int x = 0; x < gridSize; x++)
        {
            for(int y = 0; y < gridSize; y++)
            {
               SetGridObject(x,y, Instantiate(baseGridPrefab, new Vector3(gridOffset.x + x, 0, gridOffset.y + y), Quaternion.identity).GetComponent<GridObject>()) ;
            }
        }
    }

    public GridObject GetGridObject(int x, int y)
    {
        return _grid[x, y];
    }
    
    public void SetGridObject(int x, int y, GridObject gridObject)
    {
        _grid[x,y] = gridObject;
    }

    public void SetGridObject(int x, int y)
    {
        if(x >= 0 && y >= 0 && x<gridSize && y < gridSize)
        {
            Destroy(_grid[x,y].gameObject);
            _grid[x, y] = Instantiate(defenseObjects[Random.Range(0, defenseObjects.Count)].TowerPrefab, new Vector3(gridOffset.x + x, 0, gridOffset.y + y),Quaternion.identity).GetComponent<GridObject>();
        }
     
    }
}
