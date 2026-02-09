using UnityEngine;

public class EnemyHeartSystem : MonoBehaviour
{
    [SerializeField] private GameObject[] enemyHearts;
    [SerializeField] private ParticleSystem deathParticles;
    [SerializeField] private int health;

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
            Instantiate(deathParticles, transform.position, Quaternion.identity);
        }
    }


    public void TakeDamage(int damage)
    {
        if (isDead) return;
        if (damage <= 0) return;

        int newHealth = Mathf.Max(health - damage, 0);

        // Destroy heart icons for lost health
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
