using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    [SerializeField] private GameObject[] hearts;
    [SerializeField] private int health;

    private bool isDead;
    private UIManager uiManager;


    void Start()
    {
        health = hearts.Length;
        uiManager = GameObject.Find("UI Manager").GetComponent<UIManager>();
    }


    void Update()
    {
        if (isDead == true)
            uiManager.ShowGameOverPanel();
    }


    public void TakeDamage(int damage)
    {         
        health -= damage;
        Destroy(hearts[health].gameObject);

        if (health < 1)
        {
            health = 0;
            isDead = true;
        }
    }
}
