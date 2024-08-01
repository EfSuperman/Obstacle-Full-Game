using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

   [SerializeField] float MoveSpeed = 10f;
    void Start()
    {
        Instructions();
    }

    
    void Update()
    {
        MovePlayer();

    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        float zValue = Input.GetAxis("Vertical")* Time.deltaTime * MoveSpeed;
        transform.Translate(xValue,0,zValue);
    }

    void Instructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("\n Use WSAD keys to move the Cubie");
    }
}
