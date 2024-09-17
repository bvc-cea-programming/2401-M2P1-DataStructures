using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class GridManager : MonoBehaviour
{
    [SerializeField] public int gridSize = 10;
    [SerializeField] private Vector2 gridOffset = new Vector2(0.5f, 0.5f);
    [SerializeField] private GameObject baseGridPrefab;
    
    [SerializeField] public List<DefenseObjectSO> defenseObjects = new List<DefenseObjectSO>();
    
    private GridObject[,] _grid;

    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        _grid = new GridObject[gridSize, gridSize];

        for (int x = 0; x < gridSize; x++)
        {
            for (int z = 0; z < gridSize; z++)
            {
                // Add a 0.5f offset to align based on the pivot being in the bottom-left corner
                Vector3 worldPosition = new Vector3(x + 0.5f, 0, z + 0.5f);

                // Instantiate the tile at the calculated position
                GameObject tile = Instantiate(baseGridPrefab, worldPosition, Quaternion.identity);

                tile.name = $"Tile_{x}_{z}";

                // Store the grid object reference
                GridObject gridObject = tile.GetComponent<GridObject>();
                _grid[x, z] = gridObject;
            }
        }
    }





    public GridObject GetGridObject(int x, int y)
    {
        return _grid[x, y];
    }
    
    public void SetGridObject(int x, int y, GridObject gridObject)
    {
        _grid[x, y] = gridObject;
    }

    public void SetGridObject(int x, int y)
    {
        // Check if the grid position is valid (within bounds)
        if (x >= 0 && x < gridSize && y >= 0 && y < gridSize)
        {
            // Get a random defense object from the list
            int randomIndex = UnityEngine.Random.Range(0, defenseObjects.Count);
            DefenseObjectSO randomDefenseObject = defenseObjects[randomIndex];

            // Get the grid object at the specified position
            GridObject gridObject = _grid[x, y];

            if (gridObject != null)
            {
                GameObject defenseObjectInstance = Instantiate(randomDefenseObject.prefab, gridObject.transform.position, Quaternion.identity);
                gridObject.SetDefenseObject(defenseObjectInstance);
            }
        }
    }

    public DefenseObjectSO GetRandomDefenseObject()
    {
        if (defenseObjects.Count > 0)
        {
            int randomIndex = UnityEngine.Random.Range(0, defenseObjects.Count);
            return defenseObjects[randomIndex];
        }
        return null;
    }

}
