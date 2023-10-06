using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] public bool buildable;
    [SerializeField] public bool walkable;

    private void OnMouseDown()
    {
        if (GameManager.selection == true && buildable == true)
        {
            Instantiate(GameManager.selectedUnit, transform.position, Quaternion.identity);
            GetComponent<SpriteRenderer>().color = Color.clear;
            GameManager.selection = false;
            
        }
    }

    private void OnMouseOver()
    {
        if (GameManager.selection == true)
        {
            if (buildable == true)
            {
                GetComponent<SpriteRenderer>().color = Color.green;

            } else if (buildable == false)
            {
                GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
    }

    private void OnMouseExit()
    {
        if (GameManager.selection == true)
        {
            GetComponent<SpriteRenderer>().color = Color.clear;
        }
    }
}
