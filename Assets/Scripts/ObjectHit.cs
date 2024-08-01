using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
  MeshRenderer rendererr;
  void OnCollisionEnter(Collision other)
    {
      if(other.gameObject.tag == "Player")
      {
        rendererr = GetComponent<MeshRenderer>();
        rendererr.material.color = Color.red;
        gameObject.tag = "Hit";
      }
    }
}
