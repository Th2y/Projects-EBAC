using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    [SerializeField] private Projectile projectilePrefab;
    [SerializeField] private int maxProjectiles;
    private List<Projectile> projectiles = new List<Projectile>();

    private void Awake()
    {
        for(int i = 0; i < maxProjectiles; i++)
        {
            Projectile projectile = Instantiate(projectilePrefab, transform);
            projectiles.Add(projectile);
        }
    }
    public Projectile ActiveNewObject()
    {
        for(int i = 0; i < maxProjectiles; i++)
        {
            if (!projectiles[i].gameObject.activeInHierarchy)
            {
                return projectiles[i];
            }
        }
        return null;
    }
}
