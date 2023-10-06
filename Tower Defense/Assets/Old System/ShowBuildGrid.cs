using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBuildGrid : MonoBehaviour
{
    private int gridX;
    private int gridY;
    [SerializeField]
    private Sprite buildable;
    [SerializeField]
    private Sprite nonBuildable;

    public void Start()
    {
        gridX = GameObject.Find("PlayerField").GetComponent<CreateGrid>().gridX;
        gridY = GameObject.Find("PlayerField").GetComponent<CreateGrid>().gridY;
    }

    public void ShowBuildingGrid()
    {
        for (int i = 0; i < gridX; i++)
        {
            for (int j = 0; j < gridY; j++)
            {
                if (GameObject.Find($"Tile{i},{j}").GetComponent<Tile>().buildable == true)
                {
                    GameObject.Find($"Tile{i},{j}").GetComponent<SpriteRenderer>().sprite = buildable;
                    GameObject.Find($"Tile{i},{j}").GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1);
                }
                else if (GameObject.Find($"Tile{i},{j}").GetComponent<Tile>().buildable == false)
                {
                    GameObject.Find($"Tile{i},{j}").GetComponent<SpriteRenderer>().sprite = nonBuildable;
                    GameObject.Find($"Tile{i},{j}").GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1);
                }
            }
        }
    } 
}
