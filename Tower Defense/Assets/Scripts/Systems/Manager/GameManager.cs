using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool selection;
    public static int manPwr;
    public static int hearts;
    public static GameObject selectedUnit;
    [SerializeField] private GameObject defaultUnit;

    private void Awake()
    {
        selectedUnit = defaultUnit;
        manPwr = 50;
        hearts = 10;
    }
}
