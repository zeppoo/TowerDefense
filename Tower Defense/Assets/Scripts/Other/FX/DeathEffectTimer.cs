using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEffectTimer : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 1);
    }
}
