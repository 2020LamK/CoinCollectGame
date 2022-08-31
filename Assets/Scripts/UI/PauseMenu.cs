using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI, gameOverMenu, victoryMenu, coinCount, healthBar, coinImage;

    public static bool GameIsPaused = false;
    public bool playerWon = false;
    public bool playerLost = false;

    void Start()
    {
        Time.timeScale = 1f;
        coinImage.SetActive(true);
        coinCount.SetActive(true);
        healthBar.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        // when esc key is pressed, toggle pause/resume
        if (Input.GetKeyDown(KeyCode.Escape) && !playerWon && !playerLost)
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }

        // when player dies, load game over screen
        if (PlayerProperties.currentHealth <= 0 && !playerWon)
        {
            Time.timeScale = 0f;
            gameOverMenu.SetActive(true);
            playerLost = true;

            coinImage.SetActive(false);
            coinCount.SetActive(false);
            healthBar.SetActive(false);
        }

        // when boss dies, display victory screen
        if (CollisionDetector.count == 15)
        {
            Time.timeScale = 0f;
            victoryMenu.SetActive(true);
            playerWon = true;

            coinImage.SetActive(false);
            coinCount.SetActive(false);
            healthBar.SetActive(false);
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

        coinCount.SetActive(true);
        coinImage.SetActive(true);
        healthBar.SetActive(true);
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

        coinImage.SetActive(false);
        coinCount.SetActive(false);
        healthBar.SetActive(false);
    }

    public void LoadMenu() {
        GameIsPaused = false;
        SceneManager.LoadScene("Menu");
    }

    public void RestartGame() {
        Time.timeScale = 1f;
        RangedEnemyShooting.canShoot=true;
        CollisionDetector.count=0;
        GameIsPaused = false;
        SceneManager.LoadScene("Game");
    }

    public void QuitGame() {
        Application.Quit();
    }
}