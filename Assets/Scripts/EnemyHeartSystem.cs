using UnityEngine;

public class EnemyHeartSystem : MonoBehaviour
{
    public GameObject[] enemyHearts;
    public int health;

    private ScoreManager scoreManager;
    private bool isDead;

    void Start()
    {
        health = enemyHearts.Length;

        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
    }

    void Update()
    {
        if (isDead == true)
        {
            scoreManager.AddScore(1);
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;
        if (damage <= 0) return;

        int newHealth = Mathf.Max(health - damage, 0);

        // Уничтожаем соответствующие сердечки безопасно (проверяем границы и на null)
        for (int i = health - 1; i >= newHealth; i--)
        {
            if (i >= 0 && i < enemyHearts.Length && enemyHearts[i] != null)
                Destroy(enemyHearts[i].gameObject);
        }

        health = newHealth;

        if (health < 1)
        {
            health = 0;
            isDead = true;
        }
    }
}
