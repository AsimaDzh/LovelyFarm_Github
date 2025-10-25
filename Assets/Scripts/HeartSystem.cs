using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts;
    public int health;

    public void LoseHealth()
    {
        if (health > 0)
            health--;

        else if (health <= 0)
            health = 0;
    }
}
