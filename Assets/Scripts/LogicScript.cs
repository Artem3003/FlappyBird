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
    [SerializeField] public float pipeMoveSpeed;
    [SerializeField] public float cloudMoveSpeed;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text currentScoreText;
    [SerializeField] private TMP_Text highScoreText;
    public AudioSource pointSound;
    public GameOverMenuScript gameOverMenu;
    public PauseMenuScript pauseMenu;
    public PipeSpawnScript pipeSpawn;
    public GameObject score;

    void Start()
    {
        pipeMoveSpeed = 5;
        cloudMoveSpeed = 5.5f;
    }

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        if (!gameOverMenu.isEnded)
        {
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
            pointSound.Play();
            if (playerScore > 0 && playerScore % 10 == 0)
            {
                pipeMoveSpeed += 1;
                cloudMoveSpeed += 1;
                pipeSpawn.spawnRate -= 0.2f;
            }
        }
    }

    public void GameOver()
    {
        gameOverMenu.gameOverScreen.SetActive(true);
        score.SetActive(false);
        gameOverMenu.isEnded = true;
        CurrentScore();
        BestScore();
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
        if (playerScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", playerScore);
        }
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
}
