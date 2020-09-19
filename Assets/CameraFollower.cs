using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;

    public float cameraDistance = 30.0f;

    void Awake()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
    }
  
    void FixedUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    }

    //void LateUpdate()
    //{
    //    //transform.position = target.position;

    //    float newXPosition = target.transform.position.x - offset.x;
    //    float newZPosition = target.transform.position.z - offset.z;

    //    transform.position = new Vector3(newXPosition, transform.position.y, newXPosition);

    //}

}