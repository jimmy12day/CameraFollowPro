using UnityEngine;

public class CameraFollowFixedUpdate : MonoBehaviour
{
    public Transform target;
    public float smooth = 1.5f;
    public Vector3 offset;

    //FixedUpdate is much smooth than lateUpdate(), try and compare the results
    void FixedUpdate()
    {
        Vector3 disiredPosition = target.transform.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, disiredPosition, smooth);
        transform.position = smoothPosition;
        transform.LookAt(target);
    }
}
