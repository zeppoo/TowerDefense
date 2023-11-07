using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class GridPlacement : MonoBehaviour
{
    [SerializeField] private LayerMask gridLayer;
    [SerializeField] private Vector3Int closestTile;//closest tile to mouse position
    [SerializeField] private Tilemap gridTilemap; // Reference de Tilemap
    [SerializeField] public bool buildable;
    public Vector3 mousePosition;
    private bool removing = false;
    [SerializeField]private bool building = false;



    private void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);//Muispositie word gedifined
        mousePosition.z = 0f;

        closestTile = gridTilemap.WorldToCell(mousePosition);//pakt dichtsbijzijnde cell gebaseerd op muispositie
        Vector3 closesTilePos = gridTilemap.GetCellCenterWorld(closestTile);//pakt het midden van de cell

        if (Input.GetMouseButtonDown(0) && building == true)
        {
            Debug.Log("it clicks");
            buildable = GameObject.Find("BuildableArea").GetComponent<CheckBuildArea>().IsPositionBuildable(mousePosition);
            bool noCollision = GetComponent<CheckForCollisions>().CheckForCollision(closesTilePos);
            Debug.Log(noCollision);
            if (buildable && GameManager.selection && noCollision)
            {
                if (GameManager.manPwr - GameManager.selectedUnit.GetComponent<UnitStats>().price < 0)
                {
                    Debug.Log("niet genoeg geld");
                    building = false;
                    return;
                }
                else
                {
                    GameManager.manPwr -= GameManager.selectedUnit.GetComponent<UnitStats>().price;
                    Instantiate(GameManager.selectedUnit, new Vector3(closesTilePos.x, closesTilePos.y, -1), Quaternion.identity);
                    building = false;
                }
            }
        }
        else if (Input.GetMouseButtonDown(0) && removing == true)
        {
            Collider2D[] collisions = Physics2D.OverlapBoxAll(new Vector3(closesTilePos.x, closesTilePos.y, -1), new Vector2(1,1), 0);
            if (collisions.Length > 0)
            {
                foreach (Collider2D collider in collisions)
                {
                    Destroy(collider.gameObject);
                }
                return;
            }
            return;
        }
    }

    public void removal()
    {
        removing = !removing;
    }

    public void build()
    {
        building = !building;
    }

}
