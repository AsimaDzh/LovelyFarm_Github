using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    public Transform lookAt;

    private bool smooth = true;
    private float smoothSpeed = 1.0f;
    private Vector3 offset = new Vector3(0, 0, -6.5f);


    void Start()
    {
        
    }

   
    void LateUpdate()
    {
        Vector3 desiredposition = lookAt.transform.position + offset;
        transform.position = desiredposition;
    }
}
