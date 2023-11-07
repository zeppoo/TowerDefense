using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select_Unit : MonoBehaviour
{
    [SerializeField] private GameObject GridPlacement;
    [SerializeField] private GameObject unit;
    public bool active;

    public void OnButtonPress()
    {
        if(active)
        {
            GameManager.selection = true;
            GameManager.selectedUnit = unit;
            GridPlacement.GetComponent<GridPlacement>().build();
        }
    }

    private void Update()
    {
        if(!active)
        {
            GetComponent<Image>().color = Color.gray;
        }
        if(active)
        {
            GetComponent<Image>().color = Color.white;
        }
    }
}
