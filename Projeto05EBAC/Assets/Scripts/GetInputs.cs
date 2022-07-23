using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInputs : MonoBehaviour
{
    [SerializeField] protected Player player;
    [SerializeField] protected EnemyBase enemyBase;
    [SerializeField] protected EnemyRun enemyRun;

    void Update()
    {
        if(player != null)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                player.DoDamage();
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                enemyBase.DoDamage();
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                enemyRun.DoDamage();
            }
        }
    }
}
