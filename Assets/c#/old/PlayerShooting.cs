using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab of the bullet
    public Transform firePointRotation;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 20f; // Speed of the bullet
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (UiManager.isPaused)
        return;

         RotateBulletSpawnPointTowardsMouse();
        // Check for the "Firel" input (left mouse button or spacebar by default)
        if (Input.GetButtonDown ("Fire1"))
        {
            Shoot();
        }
    }
    void RotateBulletSpawnPointTowardsMouse()
    {
        // Get the mouse position in screen space and convert it to world space
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
        mousePosition.z = 0f; // Ensure z-axis is 0 for 2D space

        // Calculate the direction from the player to the mouse
        Vector2 direction = (mousePosition - firePointRotation.position).normalized;

        // Calculate the angle to rotate the fire point (using Atan2 to get angle in degrees)
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;

        // Apply the rotation to the fire point
        firePointRotation.rotation = Quaternion. Euler (new Vector3(0, 0, angle));
    }
    void Shoot ()
    {
        // Instantiate the bullet at the fire point's position and rotation
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, firePointRotation.rotation);
        // Get the Rigidbody2D component from the bullet
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        // Apply velocity to the bullet in the direction the fire point is facing
        rb.velocity = firePointRotation.up * bulletSpeed;
        Destroy(bullet, 5f);
    }
}
