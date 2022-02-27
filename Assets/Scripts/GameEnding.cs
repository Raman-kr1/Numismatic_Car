using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
  //  public GameHandler gh;
    public CoinScript cs;
    public AudioClip GameWin;

    // Start is called before the first frame update
    // void Start()
    // {
    //     cs = GameObject.Find("Canvas").GetComponent<CoinScript>();
    // }

    void Update()
    {
        if(cs.coins >= 50)
        {   
            AudioSource.PlayClipAtPoint(GameWin,transform.position);
            //for(float timeVal = 0; timeVal < 5;)
            //{
               // if(timeVal > 2)
               // {
            SceneManager.LoadScene("EndScreenWin");
              //  }
                
               // timeVal += Time.deltaTime;
           // }
        }
    }
}
