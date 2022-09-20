using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    int coins = 0;

     private void OnTriggerEnter2D(Collider2D col)
     {
        coins++;
        Debug.Log("Coins " + coins);
     }

}
