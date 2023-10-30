using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int speed;

    private void Start()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right);
        Debug.DrawRay(transform.position, transform.right, Color.white, 100);
        if (hit.collider.tag == "Enemy")
        {
            Debug.Log("hit");
        }
    }

    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hit");
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("hit");

        }
    }
}
