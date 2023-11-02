using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindNearestEnemy : MonoBehaviour
{
    private Transform targetEnemy;
    private GameObject turret;
    private float rotationSpeed;
    public GameObject[] enemies;

    private void Start()
    {
        rotationSpeed = GetComponent<UnitStats>().rotationSpeed;
        turret = GetComponent<UnitStats>().turret;
    }
    void Update()
    {
        // Detect and target the nearest enemy
        FindClosestEnemy();

        // Rotate towards the target enemy
        if (targetEnemy != null)
        {
            Vector3 direction = targetEnemy.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion lookRotation = Quaternion.AngleAxis(angle, Vector3.forward);
            turret.transform.rotation = Quaternion.Slerp(turret.transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);
        }
    }

    void FindClosestEnemy()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float shortestDistance = Mathf.Infinity;
        Transform nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector2.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy.transform;
            }
        }

        targetEnemy = nearestEnemy;
    }
}
