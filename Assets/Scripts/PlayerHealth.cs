using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage()
    {
        currentHealth = currentHealth - 1;
    }

    public void OnCollisionEnter(Collision other) 
    {
        TakeDamage();
        //Debug.Log("Collision");
    }

    void Update() 
    {
        if(currentHealth == 0)
        {
            SceneManager.LoadScene("EndScreenHealth");
        }
    }
}