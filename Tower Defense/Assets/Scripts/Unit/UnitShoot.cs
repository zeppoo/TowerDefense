using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitShoot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject target;
    [SerializeField] private bool canShoot;
    [SerializeField] private float fireRate;
    [SerializeField] private float timer;
    private GameObject turret;

    private void Start()
    {
        turret = GetComponent<UnitStats>().turret;
    }

    private void Update()
    {
        if (canShoot == false)
        {
            timer += Time.deltaTime;
            if (timer > fireRate)
            {
                canShoot = true;
            }
        }
        else if (canShoot == true)
        {
            Shoot();
            timer = 0;
            canShoot = false;
        }
    }

    public void Shoot()
    {
            Instantiate(bullet, turret.transform.position, turret.transform.rotation);
    }
}
