using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private int dmg;

    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
        Destroy(gameObject, 4);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyStats>().health -= dmg;
            Destroy(gameObject);
        }
    }
}
