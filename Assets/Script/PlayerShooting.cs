using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public float fireRate = 0.5f;
    public float projectileSpeed = 10f;
    public Transform shootSpawn;

    private float nextFireTime;
    private ProjectilePool projectilePool;

    private void Start()
    {
        projectilePool = FindObjectOfType<ProjectilePool>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextFireTime)
        {
            ShootProjectile();
            nextFireTime = Time.time + fireRate;
        }
    }

    private void ShootProjectile()
    {
        GameObject projectile = projectilePool.GetProjectile();
        projectile.transform.position = shootSpawn.position;
        projectile.SetActive(true);

        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * projectileSpeed;
    }

    
}
