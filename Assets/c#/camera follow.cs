using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform followTarget; // The target for our camera to follow.
    public float smoothTime = 0.3f; // The time it takes the camera to reach it's target.
    private Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        Vector3 targetPosition = followTarget.position;
        targetPosition.z = transform.position.z; // We don't want the Z position to change as this will mess our camera up.

        // Smoothly move the camera towards that target position
        transform.position = Vector3. SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
    public void SwitchCameraTargets (Transform newCameraTarget)
    {
        followTarget = newCameraTarget;
    }



}
