using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject projectile;
    public float fireRate;
    private int totalFire;

    private float nextFire;

    private void Awake()
    {
        totalFire = Random.Range(1, 4);
    }

    private void Update()
    {
        if(Random.Range(1, 111) == 5 && totalFire > 0) shoot();
    }

    void shoot()
    {
        if(Time.time > nextFire)
        {
            totalFire--;
            Instantiate(projectile, transform.position, transform.rotation);
            nextFire = Time.time + fireRate;
        }
    }
}
