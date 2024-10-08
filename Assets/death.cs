using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    /// if a collison happens 
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("bad wall"))
        {
            Debug.Log("Collision detected.");
            Destroy(gameObject);
        }
    }

    
}
