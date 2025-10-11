using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float horizontalInput;
    [SerializeField] float speed = 10f;
    [SerializeField] float xRange = 10f;
    private Transform gizmos;
    [SerializeField] float boxLenght;
    [SerializeField] float boxWidth;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        var pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -xRange, xRange);
        transform.position = pos;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(boxLenght, 10, boxWidth));
    }
}
