using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doortrigger : MonoBehaviour
{
    public GameObject hiddendoor;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            hiddendoor.SetActive(false);
            print("door opened");
        }
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            hiddendoor.SetActive(true);
        }
    }
}
