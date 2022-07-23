using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemiesController enemiesController;

    public void SetEnemiesController(EnemiesController enemiesController)
    {
        this.enemiesController = enemiesController;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerProjectile"))
        {
            other.gameObject.SetActive(false);
            enemiesController.OnEnemyDie();
            Destroy(this.gameObject);
        }
    }
}
