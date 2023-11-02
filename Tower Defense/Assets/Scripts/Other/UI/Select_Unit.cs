using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select_Unit : MonoBehaviour
{
    [SerializeField] private GameObject unit;
    public bool active;

    public void OnButtonPress()
    {
        if(active)
        {
            GameManager.selection = true;
            GameManager.selectedUnit = unit;
        }
    }

    private void Update()
    {
        if(!active)
        {
            GetComponent<Image>().color = Color.gray;
        }
    }
}
