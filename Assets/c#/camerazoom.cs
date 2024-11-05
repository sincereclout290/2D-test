using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerazoom : MonoBehaviour
{
    Camera cam;
    Rigidbody2D PlayerRb;
    bool zoomIn;

    [Range (2,10)]
    public float zoomSize;
    
    [Range(0.01f,0.1f)]
    public float zoomSpeed;
    
    [Range(1,3)]
    public float waitTime;
    float waitCounter;
   
   private void Awake()
   {
        cam = Camera.main;
        PlayerRb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
   }
   void ZoomIn()
   {
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, zoomSize, zoomSpeed);
   }
   void ZoomOut()
   {
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 10, zoomSpeed);
   }
   private void LateUpdate()
   {
    if(Mathf.Abs(PlayerRb.velocity.magnitude)<8) // zoom in
    {
        waitCounter += Time.deltaTime;
        if (waitCounter > waitTime)
        {
            zoomIn = true;
        }
        else // zoom out
        {
            zoomIn = false;
            waitCounter = 0;
        }
        if (zoomIn)
        {
            ZoomIn(); 
        }
        else
        {
            ZoomOut ();
        }
    }
   }
}
