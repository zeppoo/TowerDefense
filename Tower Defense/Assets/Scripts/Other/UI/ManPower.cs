using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ManPower : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GetComponent<TMP_Text>().text = GameManager.manPwr.ToString();
    }
}
