using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int speed;

    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
    }
}
