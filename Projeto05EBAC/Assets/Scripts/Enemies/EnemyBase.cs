using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    [SerializeField] protected Player player;

    [SerializeField] protected MeshRenderer enemyMesh;
    [SerializeField] protected EnemyData enemyData;

    protected float life;
    protected float damage;
    private Coroutine defineColor;

    protected void Awake()
    {
        enemyMesh.material.color = enemyData.initialColor;
    }

    protected void Start()
    {
        life = enemyData.life;
        damage = enemyData.damage;
    }

    public virtual void TakeDamage(float damage)
    {
        life -= damage;
        if (life <= 0)
        {
            Destroy(this.gameObject);
        }
        else
        {
            defineColor = StartCoroutine(ChangeColor());
        }
    }

    private IEnumerator ChangeColor()
    {
        enemyMesh.material.color = enemyData.damageColor;
        yield return new WaitForSeconds(1f);
        enemyMesh.material.color = enemyData.initialColor;
        defineColor = null;
    }

    public virtual void DoDamage()
    {
        player.TakeDamage(damage);
    }
}
