using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select_Unit : MonoBehaviour
{
    [SerializeField] private GameObject unit;

    public void OnButtonPress()
    {
        GameManager.selection = true;
        GameManager.selectedUnit = unit;
    }
}
