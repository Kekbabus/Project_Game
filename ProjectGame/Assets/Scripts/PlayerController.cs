using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    private float mspeed = 1.0f;
    //private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRb;
    private GameObject focalPoint;
    //public Transform orientation;

    //Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        //float horizontalInput2 = Input.GetAxis("Horizontal");
        //float forwardInput2 = Input.GetAxis("Vertical");
         horizontalInput = Input.GetAxis("Horizontal");
         forwardInput = Input.GetAxis("Vertical");

        //playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput2);
         //playerRb.AddForce(focalPoint.transform.forward * speed * horizontalInput2);

        //move player foward here
        // transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //transform.Translate(Vector3.horizontal * Time.deltaTime * speed * horizontalInput);

        //gets player model to rotate 
        //transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, forwardInput);

        transform.position += moveDirection * mspeed;

        //moveDirection = orientation.forward * forwardInput * orientation.right * horizontalInput;
        //rbAddForce(moveDirection.normalized * mspeed * 10f);
    }
}
