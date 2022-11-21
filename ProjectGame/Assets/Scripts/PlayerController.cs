using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float mspeed = 1.0f;
    //private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //move player foward here
        // transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //transform.Translate(Vector3.horizontal * Time.deltaTime * speed * horizontalInput);

        //gets player model to rotate 
        //transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, forwardInput);

        transform.position += moveDirection * mspeed;
    }
}
