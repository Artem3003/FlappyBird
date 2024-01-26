using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    private AudioSource[] audios;
    public int playerScore;
    public TMP_Text scoreText;
    public TMP_Text currentScoreText;
    public AudioSource pointSound;
    public GameOverMenuScript gameOverMenu;
    public PauseMenuScript pauseMenu;
    public GameObject score;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        if (!gameOverMenu.isEnded)
        {
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
            pointSound.Play();
        }
    }

    public void GameOver()
    {
        gameOverMenu.gameOverScreen.SetActive(true);
        score.SetActive(false);
        gameOverMenu.isEnded = true;
        CurrentScore();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MenuScene");
        pauseMenu.Resume();
        gameOverMenu.isEnded = false;
    }
    public void QuitGme()
    {
        Application.Quit();
    }

    
    public void CurrentScore()
    {
        currentScoreText.text = playerScore.ToString();
    }

    public void BestScore()
    {
        
    }
}
