using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20.0f;
    private float rotationSpeed = 45.0f;
    private float verticalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        forwardInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward*Time.deltaTime * speed*forwardInput);

        // tilt the plane up/down based on up/down arrow keys
        transform.Translate(Vector3.up * rotationSpeed * Time.deltaTime*verticalInput);
    }
}
