using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public int rotSpeed =200;
    void Update()
    {
         transform.Rotate(0, rotSpeed * Time.deltaTime, 0, Space.World);
    }
}
