using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {

    }
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGme()
    {
        Application.Quit();
    }
}
