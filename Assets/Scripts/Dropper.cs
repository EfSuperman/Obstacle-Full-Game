using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    float TimeToWait = 3f;
    MeshRenderer rendrer;
    Rigidbody rigidBody;

    void Start()
    {
        rendrer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        rendrer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > TimeToWait)
        {
            rendrer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
