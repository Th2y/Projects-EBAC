using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private MeshRenderer playerMesh;
    [SerializeField] private PlayerData playerData;

    [SerializeField] private EnemyBase[] enemies;

    private Color initialColor;
    private float life;
    private float damage;
    private Coroutine defineColor;

    private void Awake()
    {
        DefineInitialColor();
    }

    private void Start()
    {
        life = playerData.life;
        damage = playerData.damage;
    }

    private void DefineInitialColor()
    {
        initialColor = new Color(
            PlayerPrefs.GetFloat("PlayerColorRValue", playerData.initialColor.r),
            PlayerPrefs.GetFloat("PlayerColorGValue", playerData.initialColor.g),
            PlayerPrefs.GetFloat("PlayerColorBValue", playerData.initialColor.b));

        playerMesh.material.color = initialColor;
    }

    public void TakeDamage(float damage)
    {
        life -= damage;
        if(life <= 0)
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
        playerMesh.material.color = playerData.damageColor;
        yield return new WaitForSeconds(1f);
        DefineInitialColor();
        defineColor = null;
    }

    public void DoDamage()
    {
        foreach(EnemyBase enemy in enemies)
        {
            if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }
        }
    }
}
