using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    [SerializeField] private Transform lookAt = null;
    [SerializeField] private float smoothSpeed = 5f;
    [SerializeField] private Vector3 offset, minValue, maxValue;

    void LateUpdate()
    {
        Vector3 desiredPosition = lookAt.position + offset;
        
        Vector3 clampPosition = new Vector3(
            Mathf.Clamp(desiredPosition.x, minValue.x, maxValue.x),
            Mathf.Clamp(desiredPosition.y, minValue.y, maxValue.y),
            Mathf.Clamp(desiredPosition.z, minValue.z, maxValue.z));

        Vector3 smoothPosition = Vector3.Lerp(
            transform.position, 
            clampPosition, 
            smoothSpeed * Time.deltaTime);

        transform.position = smoothPosition;
        transform.LookAt(lookAt);
    }
}
