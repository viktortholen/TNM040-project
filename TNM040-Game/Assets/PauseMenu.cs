﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;

    public GameObject OMenuUI;

    // Update is called once per frame
    void Update () {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().buildIndex > 0)
            {
                FindObjectOfType<AudioManager>().Play("menu");
            }

            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }

        
	}
    public void Resume()
        {
            PauseMenuUI.SetActive(false);

        OMenuUI.SetActive(false);
        Time.timeScale = 1f;
            GameIsPaused = false;
        }
		
        void Pause()
         {
            PauseMenuUI.SetActive(true);
        
        Time.timeScale = 0f;
            GameIsPaused = true;

        }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
    public void QuitGame()
        {
        Debug.Log("Quitting...");
        Application.Quit();
        }
}
