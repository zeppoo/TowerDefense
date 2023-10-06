using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitShoot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject turret;
    [SerializeField] private GameObject target;
    [SerializeField] private bool canShoot;
    [SerializeField] private float fireRate;

    public void Shoot()
    {
        if (canShoot)
        {
            Instantiate(bullet, turret.transform.position, turret.transform.rotation);
        }
    }
}
