using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCycle : MonoBehaviour
{
    [SerializeField] ProjectileSpawner projectileSpawner;
    [SerializeField] GameObject[] demoProjectiles1;
    [SerializeField] GameObject[] demoProjectiles2;
    [SerializeField] GameObject[] demoProjectiles3;
    [SerializeField] GameObject[] demoProjectiles4;
    [SerializeField] GameObject[] demoProjectiles5;

    private void Start()
    {
        foreach (var projectile in demoProjectiles1)
        {
            projectile.SetActive(true);
        }
        foreach (var projectile in demoProjectiles2)
        {
            projectile.SetActive(false);
        }
        foreach (var projectile in demoProjectiles3)
        {
            projectile.SetActive(false);
        }
        foreach (var projectile in demoProjectiles4)
        {
            projectile.SetActive(false);
        }
        foreach (var projectile in demoProjectiles5)
        {
            projectile.SetActive(false);
        }
    }

    public void CycleProjectiles()
    {
        if(projectileSpawner.projectiles == projectileSpawner.projectiles1)
        {
            projectileSpawner.projectiles = projectileSpawner.projectiles2;
            foreach(GameObject go in demoProjectiles1)
            {
                go.SetActive(false);
            }
            foreach (GameObject go in demoProjectiles2)
            {
                go.SetActive(true);
            }
        }
        else if (projectileSpawner.projectiles == projectileSpawner.projectiles2)
        {
            projectileSpawner.projectiles = projectileSpawner.projectiles3;
            foreach (GameObject go in demoProjectiles2)
            {
                go.SetActive(false);
            }
            foreach (GameObject go in demoProjectiles3)
            {
                go.SetActive(true);
            }
        }
        else if (projectileSpawner.projectiles == projectileSpawner.projectiles3)
        {
            projectileSpawner.projectiles = projectileSpawner.projectiles4;
            foreach (GameObject go in demoProjectiles3)
            {
                go.SetActive(false);
            }
            foreach (GameObject go in demoProjectiles4)
            {
                go.SetActive(true);
            }
        }
        else if (projectileSpawner.projectiles == projectileSpawner.projectiles4)
        {
            projectileSpawner.projectiles = projectileSpawner.projectiles5;
            foreach (GameObject go in demoProjectiles4)
            {
                go.SetActive(false);
            }
            foreach (GameObject go in demoProjectiles5)
            {
                go.SetActive(true);
            }
        }
        else if (projectileSpawner.projectiles == projectileSpawner.projectiles5)
        {
            projectileSpawner.projectiles = projectileSpawner.projectiles1;
            foreach (GameObject go in demoProjectiles5)
            {
                go.SetActive(false);
            }
            foreach (GameObject go in demoProjectiles1)
            {
                go.SetActive(true);
            }
        }

    }
}
