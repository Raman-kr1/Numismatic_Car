using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenuWin : MonoBehaviour
{
    public void PlayAgainWin()
    {
        SceneManager.LoadScene("Game scene");
    }

    public void StartScreenButtonWin()
    {
        SceneManager.LoadScene("StartScreen");
    }
    
    public void QuitButtonWin()
    {
        Application.Quit();
    }
}
