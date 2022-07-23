using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PoolManager poolManager;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private PlayerData playerData;
    [SerializeField] private MeshRenderer playerMesh;
    [SerializeField] private Vector3 direction;

    public void MoveToRight()
    {
        transform.Translate(direction * Time.deltaTime);
    }

    public void MoveToLeft()
    {
        transform.Translate(-direction * Time.deltaTime);
    }

    public void ChangeToStateStart()
    {
        playerMesh.material.color = playerData.startColor;
    }

    public void ChangeToStateAlive()
    {
        playerMesh.material.color = playerData.aliveColor;
    }

    public void ChangeToStateDie()
    {
        playerMesh.material.color = playerData.dieColor;
    }

    public void WhenShooting()
    {
        Projectile projectile = poolManager.ActiveNewObject();
        if(projectile != null)
        {
            projectile.transform.SetParent(null);
            projectile.Init();
            projectile.transform.position = shootPoint.transform.position;
        }
    }
}
