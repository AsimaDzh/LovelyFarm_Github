using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    [SerializeField] float speed = 10f;
    [SerializeField] float xRange = 10f;
    private Transform gizmos;
    [SerializeField] float boxLenght;
    [SerializeField] float boxWidth;
    [SerializeField] GameObject projectilePrefab;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        var pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -xRange, xRange);
        transform.position = pos;

        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(boxLenght, 10, boxWidth));
    }
}
