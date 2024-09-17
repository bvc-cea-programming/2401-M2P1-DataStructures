using System;
using UnityEngine;

public class GridInteractor : MonoBehaviour
{
    [SerializeField] private LayerMask interactionLayerMask;  // For detecting raycast hits on grid
    [SerializeField] private GameObject[] defensePrefabs;     // Array of defense objects to place

    private GridManager gridManager;
    private Camera _mainCamera;

    private void Start()
    {
        _mainCamera = Camera.main;
        gridManager = GetComponent<GridManager>();  // Make sure GridManager is on the same GameObject
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))  // Detect left mouse button click
        {
            Vector2Int gridPosition = GetGridPosition(Input.mousePosition);
            Debug.Log("Grid Position: " + gridPosition);

            // Ensure the clicked position is valid before placing an object
            if (gridPosition.x >= 0 && gridPosition.x < gridManager.gridSize &&
                gridPosition.y >= 0 && gridPosition.y < gridManager.gridSize)
            {
                PlaceDefenseObjectAtGrid(gridPosition);
            }
        }
    }

    private void PlaceDefenseObjectAtGrid(Vector2Int gridPosition)
    {
        // Retrieve the grid object at the clicked grid position
        GridObject gridTile = gridManager.GetGridObject(gridPosition.x, gridPosition.y);

        if (gridTile != null)
        {
            // Get the world position of the tile (center of the tile)
            Vector3 tileWorldPosition = gridTile.transform.position;

            // Randomly select a defense object from the list of ScriptableObjects
            DefenseObjectSO defenseObject = gridManager.GetRandomDefenseObject();

            if (defenseObject != null && defenseObject.prefab != null)
            {
                // Place the object exactly at the tile's center position
                GameObject placedObject = Instantiate(defenseObject.prefab, tileWorldPosition, Quaternion.identity);

                // Store the placed object in the grid tile to ensure it can be replaced later
                gridTile.SetDefenseObject(placedObject);

                Debug.Log($"Placed {defenseObject.name} at {tileWorldPosition}");
            }
        }
    }

    #region DO_NOT_MODIFY

    /// <summary>
    /// Get grid position on any given surface as an integer from screen position.
    /// </summary>
    /// <param name="screenPosition"></param>
    /// <returns></returns>
    private Vector2Int GetGridPosition(Vector2 screenPosition)
    {
        var gridPosition = new Vector2Int();
        if (Physics.Raycast(_mainCamera.ScreenPointToRay(screenPosition), out var hit, float.MaxValue,
                interactionLayerMask))
        {
            gridPosition = new Vector2Int(Mathf.FloorToInt(hit.point.x), Mathf.FloorToInt(hit.point.z));
        }

        return gridPosition;
    }

    #endregion
}
