using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] float speed = 10f;
    [SerializeField] float xRange = 10f;

    private float _startTimeBetweenShots = 0.2f;
    private float _timeBetweenShots;
    private float _horizontalInput;


    private void Start()
    {
        _timeBetweenShots = 0f;
    }


    private void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * _horizontalInput * speed * Time.deltaTime);

        var pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -xRange, xRange);
        transform.position = pos;

        if (_timeBetweenShots <= 0f && Input.GetMouseButton(0))
        {
            ShotBread();
        }
        else
        {
            _timeBetweenShots -= Time.deltaTime;
        }
    }


    private void ShotBread()
    {
        Instantiate(
            projectilePrefab,
            transform.position,
            projectilePrefab.transform.rotation
        );
        _timeBetweenShots = _startTimeBetweenShots;
    }
}
