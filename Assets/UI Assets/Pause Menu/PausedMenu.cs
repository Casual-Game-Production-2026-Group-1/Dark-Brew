using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedMenu : MonoBehaviour
{
    public GameObject pausedMenu;
    public bool isPaused;
    void Start()
    {
        pausedMenu.SetActive(false);

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
        }

    }

    public void PauseGame()
    {
        pausedMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pausedMenu.SetActive(false);
            Time.timeScale = 1f;
         isPaused = false;
    }
}