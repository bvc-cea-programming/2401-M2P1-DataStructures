using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using static UnityEditor.Progress;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int gridSize = 10;
    [SerializeField] private Vector2 gridOffset = new Vector2(0.5f, 0.5f);
    [SerializeField] private GridObject baseGridPrefab;
    [SerializeField] private GameObject gameBoard;
    [SerializeField] private List<DefenseObjectSO> defenseObjects = new List<DefenseObjectSO>();
    
    private GridObject[,] _grid;
    private GridObject[,] _gridObjects;

    private int randomNum;

    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        //GridObject a = baseGridPrefab;
        _grid = new GridObject[gridSize, gridSize];
        _gridObjects = new GridObject[gridSize, gridSize];
        for (int x = 0; x < gridSize; x++)
        {
            for (int y = 0; y < gridSize; y++)
            {
                _grid[x, y] = Instantiate<GridObject>(baseGridPrefab, new Vector3(gridOffset.x + x, 0, gridOffset.y + y), Quaternion.identity, gameBoard.transform);
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
        if (x >= 0 && x < gridSize && y >= 0 && y < gridSize)
        { 
            randomNum = UnityEngine.Random.Range(0, defenseObjects.Count);
            if (_gridObjects[x, y] != null)
            {
                Destroy(_gridObjects[x, y].gameObject);
                _gridObjects[x, y] = null;
            }
            _gridObjects[x, y] = Instantiate<GridObject>(defenseObjects[randomNum].objectPrefab, _grid[x, y].transform, false);
            _gridObjects[x, y].transform.SetLocalPositionAndRotation(Vector3.zero + defenseObjects[randomNum].locationOffset, Quaternion.identity);
        }

    }
}
