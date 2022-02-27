using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinScript : MonoBehaviour
{
   //public GameHandler gh;
    public AudioClip coinSound;
    public TextMeshProUGUI coinText;
    public int coins=0;
    // Start is called before the first frame update
    // void Start()
    // {
    //     gh = GameObject.Find("Canvas").GetComponent<GameHandler>();
    // }

    
    void OnTriggerEnter(Collider other) 
    {
        if(other.transform.tag == "Coin")
        {
            coins++;
            AudioSource.PlayClipAtPoint(coinSound,transform.position);
            Destroy(other.gameObject);
        }    
    }
    void Update()
    {
        coinText.text="COINS : " + coins + " / 50";
    }
}
