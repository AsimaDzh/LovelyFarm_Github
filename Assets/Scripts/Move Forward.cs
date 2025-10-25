using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] float foodSpeed = 40f;
    private float speedAnimal;

    void Start()
    {
        speedAnimal = Random.Range(1, 5);
    }

    void Update()
    {
        if (this.CompareTag("Food"))
            transform.Translate(Vector3.forward * foodSpeed * Time.deltaTime);
        else if (this.CompareTag("Animal"))
            transform.Translate(Vector3.forward * speedAnimal * Time.deltaTime);
    }
}
