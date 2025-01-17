using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenuController : MonoBehaviour
{
    // Check if game is paused
    // Accesible from other scripts
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
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
        // Hide Menu
        pauseMenuUI.SetActive(false);

        // Continue game time
        Time.timeScale = 1f;

        GameIsPaused = false;
    }

    void Pause()
    {
        // Show Menu
        pauseMenuUI.SetActive(true);

        // Stop game from running
        Time.timeScale = 0f;

        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        // Won't do anything in unity editor. Debug is there to checkk functionality.
        Debug.Log("Quit");
        Application.Quit();
    }
}
