using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    
    [Header("Camera Settings")]
    public float followSpeed = 5f;
    public float lookAheadDistance = 3f;
    public float lookAheadSpeed = 2f;

    private Vector3 lastTargetPosition;
    private float currentLookAheadX;

    void Start()
    {
        if (target != null)
            lastTargetPosition = target.position;
    }

    void LateUpdate()
    {
        if (target == null) return;

        float xMoveDelta = target.position.x - lastTargetPosition.x;
        
        float desiredLookAheadX = currentLookAheadX;
        
        if (Mathf.Abs(xMoveDelta) > 0.001f) 
        {
            desiredLookAheadX = Mathf.Sign(xMoveDelta) * lookAheadDistance;
        }
        
        currentLookAheadX = Mathf.Lerp(currentLookAheadX, desiredLookAheadX, Time.deltaTime * lookAheadSpeed);
        
        Vector3 targetCameraPosition = new (
            target.position.x + currentLookAheadX,
            target.position.y,
            transform.position.z
        );
        
        transform.position = Vector3.Lerp(transform.position, targetCameraPosition, Time.deltaTime * followSpeed);
        lastTargetPosition = target.position;
    }
}
