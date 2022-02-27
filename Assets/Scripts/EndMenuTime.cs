using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenuTime : MonoBehaviour
{
    public void PlayAgainTime()
    {
        SceneManager.LoadScene("Game scene");
    }

    public void StartScreenButtonTime()
    {
        SceneManager.LoadScene("StartScreen");
    }
    
    public void QuitButtonTime()
    {
        Application.Quit();
    }
}
