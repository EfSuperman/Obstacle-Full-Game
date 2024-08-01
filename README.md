# Obstacle-Full-Game
using System.Collections; using System.Collections.Generic; using UnityEngine;

public class Mover : MonoBehaviour { //to move player using these variables [SerializeField] float xValue = 0f; [SerializeField] float yValue = 0.01f; [SerializeField] float zValue = 0f; void Start() {

}


void Update()
{
    transform.Translate(xValue,yValue,zValue);
}
}

[SerializeField] is used to set values of (x,y,z) in unity

transform.Translate is used to acces the xyz axis

public class Mover : MonoBehaviour {

void Start()
{
    
}


void Update()
{
    float xValue = Input.GetAxis("Horizontal");
    float zValue = Input.GetAxis("Vertical");
    transform.Translate(xValue,0,zValue);
}
}

Input.GetAxis is used to control with keys

public class Mover : MonoBehaviour {

[SerializeField] float MoveSpeed = 10f; void Start() {

}


void Update()
{
    float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
    float zValue = Input.GetAxis("Vertical")* Time.deltaTime * MoveSpeed;
    transform.Translate(xValue,0,zValue);
}
}

Time.deltaTime is used to add delay in object according to environment or fps(according to device)

where * MoveSpeed is used to set speed acccourding to need

public class Mover : MonoBehaviour {

[SerializeField] float MoveSpeed = 10f; void Start() { Instructions(); }

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

calling functions make it more convenient

public class ObjectHit : MonoBehaviour { void OnCollisionEnter(Collision other) { Debug.Log("Bumped into the wall"); } }

OnCollisionEnter(Collision other) is used for collusion between objects

public class Dropper : MonoBehaviour { float TimeToWait = 3f; MeshRenderer rendrer; Rigidbody rigidBody;

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

Time.time is used to access time of starting project

using System.Collections; using System.Collections.Generic; using UnityEngine;

public class ObjectHit : MonoBehaviour { MeshRenderer rendererr; void OnCollisionEnter(Collision other) { if(other.gameObject.tag == "Player") { rendererr = GetComponent(); rendererr.material.color = Color.red; gameObject.tag = "Hit"; } } }

other.gameObject.tag is used to assign tags of objects

using System.Collections; using System.Collections.Generic; using UnityEngine;

public class Dropper : MonoBehaviour { float TimeToWait = 3f; MeshRenderer rendrer; Rigidbody rigidBody;

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
