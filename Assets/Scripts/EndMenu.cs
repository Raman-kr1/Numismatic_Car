using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("Game scene");
    }

    public void StartScreenButton()
    {
        SceneManager.LoadScene("StartScreen");
    }
    
    public void QuitButton()
    {
        Application.Quit();
    }
}
