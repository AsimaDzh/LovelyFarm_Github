using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            score += 1;
            Debug.Log("Score: " + score);
        }
    }
}
