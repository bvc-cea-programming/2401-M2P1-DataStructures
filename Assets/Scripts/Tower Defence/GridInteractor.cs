using System;
using UnityEngine;

public class GridInteractor : MonoBehaviour
{
    [SerializeField] private LayerMask interactionLayerMask;
    [SerializeField] 
    private Camera _mainCamera;
    [SerializeField]
    GridManager _gridManager;
    private void Start()
    {
        _mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2Int gridPosition = GetGridPosition(Input.mousePosition);
            Debug.Log(gridPosition);
            _gridManager.SetGridObject(gridPosition.x,gridPosition.y);
          //  ;
          //  gridPosition.y;
            // Add your code here. Use gridPosition to get the x and y value of the grid.
            
        }
    }

    #region  DO_NOT_MODIFY

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
