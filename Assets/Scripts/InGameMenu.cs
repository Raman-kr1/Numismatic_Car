using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    public void PauseGame ()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame ()
    {
        Time.timeScale = 1;
    }

    public void StartScreenGame()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void PlayGameAgain()
    {
        SceneManager.LoadScene("Game scene");
    }
}
