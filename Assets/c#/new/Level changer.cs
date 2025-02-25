using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Levelchanger : MonoBehaviour
{
    public int index;
    public string levelName;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(levelName);
            Debug.Log("Going you are now");
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void changeScene()
    {
        SceneManager.LoadScene(levelName);
    }

}
