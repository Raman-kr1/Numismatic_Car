using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAudio : MonoBehaviour
{
    public AudioClip CollisionSound;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "player"){
          AudioSource.PlayClipAtPoint(CollisionSound,transform.position);
        }
    }
}
