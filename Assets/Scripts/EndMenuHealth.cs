using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenuHealth : MonoBehaviour
{
    public void PlayAgainHealth()
    {
        SceneManager.LoadScene("Game scene");
    }

    public void StartScreenButtonHealth()
    {
        SceneManager.LoadScene("StartScreen");
    }
    
    public void QuitButtonHealth()
    {
        Application.Quit();
    }
}

