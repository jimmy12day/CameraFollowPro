//Bin Wei, 12/21/2017
using UnityEngine;

public class CameraFollowLateUpdate : MonoBehaviour
{
    public Transform target;
    public float smooth = 1.5f;
    public Vector3 offset;


    // LateUpdate is kind of laggy, use fixedUpdate instead, why? Think about it
    void LateUpdate()
    {
        Vector3 disiredPosition = target.transform.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, disiredPosition, smooth);
        transform.position = smoothPosition;
        transform.LookAt(target);
    }
}
