using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Levelchanger : MonoBehaviour
{
    public string levelName;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(levelName);
            Debug.Log("Going you are now");
        }

    }
    public void changeScene()
    {
        SceneManager.LoadScene(levelName);
    }

}
