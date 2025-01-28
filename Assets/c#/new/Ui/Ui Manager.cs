using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public GameObject pauseMenuUI; //Reference to our UI so we can enable it and hide it
    public static bool isPaused = false; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // You can change the key
        {
            if (isPaused) ResumeGame(); //If the game is already paused, resume it
            else PauseGame();
        }
    }
    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void QuitGame()
    {
        Debug.Log("Quitting the game you are");
        Application.Quit();
    }
}
