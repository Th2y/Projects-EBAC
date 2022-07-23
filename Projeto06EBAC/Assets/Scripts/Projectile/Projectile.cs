using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float timeToDestroy = 3f;

    private void Update()
    {
        transform.Translate(direction * Time.deltaTime);
    }

    public void Init()
    {
        gameObject.SetActive(true);
        Invoke(nameof(Finish), timeToDestroy);
    }

    public void Finish()
    {
        gameObject.SetActive(false);
    }
}
