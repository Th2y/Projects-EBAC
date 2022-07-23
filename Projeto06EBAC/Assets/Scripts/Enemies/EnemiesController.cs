using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesController : MonoBehaviour
{
    [SerializeField] private Enemy[] enemies;
    [SerializeField] private InputController inputController;

    private int enemiesLenght = 0;

    private void Awake()
    {
        enemiesLenght = enemies.Length;
        for(int i = 0; i < enemiesLenght; i++)
        {
            enemies[i].SetEnemiesController(this);
        }
    }

    public void OnEnemyDie()
    {
        enemiesLenght--;
        if(enemiesLenght == 0)
        {
            inputController.ChangeState(States.DIE);
        }
    }
}
