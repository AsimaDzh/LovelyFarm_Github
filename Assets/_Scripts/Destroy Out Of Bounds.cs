using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -4.0f;
    private HeartSystem heartSystem;

    void Awake()
    {
        heartSystem = GameObject.Find("Woman").GetComponent<HeartSystem>();
    }

    void Update()
    {
        if (transform.position.z > topBound)
            Destroy(gameObject);
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            heartSystem.TakeDamage(1);
        }
    }
}
