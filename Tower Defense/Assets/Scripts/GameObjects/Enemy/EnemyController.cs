using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int health;
    [SerializeField] private int reward;
    [SerializeField] private float speed;
    [SerializeField] private GameObject deathFX;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (health <= 0)
        {
            Die();
        }
    }
    
    private void Move()
    {
        transform.position += -transform.right * speed * Time.deltaTime;
    }

    private void Die()
    {
        GameManager.manPwr += reward;
        Instantiate(deathFX, transform.position, Quaternion.identity);
        Object.Destroy(gameObject);
    }

    
}
