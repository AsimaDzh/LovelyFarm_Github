using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] float speed = 40f;


    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
