using System;
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
    
    private GridObject[,] _grid;

    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        
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
        
    }
}
