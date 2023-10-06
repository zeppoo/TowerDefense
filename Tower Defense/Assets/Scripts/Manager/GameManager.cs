using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool selection;
    public static GameObject selectedUnit;
    [SerializeField] private GameObject defaultUnit;

    private void Start()
    {
        selectedUnit = defaultUnit;
    }
}
