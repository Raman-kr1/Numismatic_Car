using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    /*
    private Slider slider;
    public void SetMaxHealth(int health){
        slider.maxValue = health;
        slider.value= health;
    }
    public void SetHealth(int health){
        slider.value = health;
    }
    */
    public Text healthText;   
    public PlayerHealth pH;

    void Update()
    {
        DisplayHealth(pH.currentHealth);
    }

    void DisplayHealth(int Health)
    {
        if(Health < 0)
        {
            Health = 0;
        }

        healthText.text = string.Format("Health: {0}", Health);
    } 


}
