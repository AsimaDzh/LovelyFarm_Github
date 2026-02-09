using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private EnemyHeartSystem enemyHeartSystem;


    void Start()
    {
        enemyHeartSystem = GetComponent<EnemyHeartSystem>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            Destroy(other.gameObject);
            if (enemyHeartSystem != null)
                enemyHeartSystem.TakeDamage(1);
        }
    }
}
