using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGrid : MonoBehaviour
{
    [SerializeField]
    public int gridX;
    [SerializeField]
    public int gridY;

    [SerializeField]
    private int buildX;
    [SerializeField]
    public int buildY;

    [SerializeField]
    private Tile tile_prefab;

    [SerializeField]
    private List<Tile> tiles;

    [SerializeField] private Transform cam;

    private Transform basePoint;

    private void Start()
    {
        basePoint = GetComponent<Transform>();
        GenerateGrid();
        DefineBuildableTiles();
    }

    public void GenerateGrid()
    {
        for (int i = 0; i < gridX; i++)
        {
            for (int j = 0; j < gridY; j++)
            {
                var spawnedTile = Instantiate(tile_prefab, new Vector3(basePoint.position.x + i -0.5f, basePoint.position.y + j -0.5f, -1.5f), Quaternion.identity);
                spawnedTile.name = $"Tile{i},{j}";
            }
        }
    }

    public void DefineBuildableTiles()
    {
        for (int i = 0; i < buildX; i++)
        {
            for (int j = 0; j < buildY; j++)
            {
                GameObject.Find($"Tile{i},{j}").GetComponent<Tile>().buildable = true;
            }
        }
    }
}
