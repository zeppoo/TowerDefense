using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridPlacement : MonoBehaviour
{
    [SerializeField] private LayerMask gridLayer;
    [SerializeField] private Vector3Int closestTile;//closest tile to mouse position
    [SerializeField] private Tilemap gridTilemap; // Reference de Tilemap
    [SerializeField] public bool buildable;
    public Vector3 mousePosition;



    private void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);//Muispositie word gedifined
        mousePosition.z = 0f;

        closestTile = gridTilemap.WorldToCell(mousePosition);//pakt dichtsbijzijnde cell gebaseerd op muispositie
        Vector3 closesTilePos = gridTilemap.GetCellCenterWorld(closestTile);//pakt het midden van de cell

        if (Input.GetMouseButtonDown(0))
        {
            buildable = GameObject.Find("BuildableArea").GetComponent<CheckBuildArea>().IsPositionBuildable(mousePosition);
            bool noCollision = GetComponent<CheckForCollisions>().CheckForCollision(closesTilePos);

            if (buildable && GameManager.selection && noCollision)
            {
                Instantiate(GameManager.selectedUnit, new Vector3(closesTilePos.x, closesTilePos.y, -1), Quaternion.identity);
            }
        }
    }
}
