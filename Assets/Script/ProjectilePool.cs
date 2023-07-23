using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePool : MonoBehaviour
{
    public GameObject projectilePrefab;
    public int poolSize = 10;

    private List<GameObject> projectilePool = new List<GameObject>();

    private void Start()
    {
        CreateProjectilePool();
    }

    private void CreateProjectilePool()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject projectile = InstantiateProjectile();
            projectilePool.Add(projectile);
        }
    }

    public GameObject GetProjectile()
    {
        GameObject projectile = null;

        // Cerca un proiettile inattivo nel pool.
        foreach (var proj in projectilePool)
        {
            if (!proj.activeInHierarchy)
            {
                projectile = proj;
                break;
            }
        }

        // Se non ci sono proiettili inattivi, crea un nuovo proiettile.
        if (projectile == null)
        {
            projectile = InstantiateProjectile();
            projectilePool.Add(projectile);
        }

        projectile.SetActive(true);
        return projectile;
    }

    private GameObject InstantiateProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, transform);
        projectile.SetActive(false);
        return projectile;
    }


    public void ReturnProjectile(GameObject projectile)
    {
        projectile.SetActive(false);
    }
}
