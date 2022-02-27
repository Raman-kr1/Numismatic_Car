using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionandhealth : MonoBehaviour
{
    public PlayerHealth playerHealth;
   
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "player"){
          
            playerHealth.TakeDamage();
        }
    }
}
