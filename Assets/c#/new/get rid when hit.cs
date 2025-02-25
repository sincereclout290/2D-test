using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class getridwhenhit : MonoBehaviour
{
    public GameObject Thingtodestroy;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(Thingtodestroy);
        }
    }
}
