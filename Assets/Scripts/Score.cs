using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int Hits = 0;
 private void OnCollisionEnter(Collision other) 
  {
    if(other.gameObject.tag != "Hit")
    {
    Hits++;
    Debug.Log("You Hits the wall " + Hits + " times");
    }
  }
}
