using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatecode: MonoBehaviour
{
    public GameObject target; // Assign the object to orbit around in the inspector
    public float rotationSpeed = 100f; // Adjust the rotation speed
        void Update()
        {
        // Rotate around the target's position
            transform.RotateAround(target.transform.position, Vector3.forward, rotationSpeed * Time.deltaTime);
        }
}
