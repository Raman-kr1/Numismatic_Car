using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IITKANPURMenu : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("StartScreen");
    }
}
