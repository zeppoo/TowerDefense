using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    [SerializeField] private GameObject counter;
    [SerializeField] private GameObject[] buttons;
    private int newestUpgrade = 0;
    public int cost;

    private void Start()
    {
        counter.GetComponent<TMP_Text>().text = cost.ToString();
    }

    public void OnButtonPress()
    {
        if (GameManager.manPwr >= cost)
        {
            buttons[newestUpgrade].GetComponent<Select_Unit>().active = true;
            newestUpgrade++;
            GameManager.manPwr -= cost;

            if (newestUpgrade > 5)
            {
                Destroy(gameObject);
            }

            cost = cost * 2;
            counter.GetComponent<TMP_Text>().text = cost.ToString();
        }
    }
}
