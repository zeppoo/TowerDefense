using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLine : MonoBehaviour
{
    [SerializeField] private LayerMask enemies;
    [SerializeField] private GameObject hearts;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("!!!");
            hearts.GetComponent<Hearts>().LoseHearts();
            Destroy(collision.gameObject);
        }
    }
}
