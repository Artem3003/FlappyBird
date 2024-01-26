using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class GameOverMenuScript : MonoBehaviour
{
    public bool isEnded = false;
    public GameObject gameOverScreen;

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        isEnded = false;
    }
}
