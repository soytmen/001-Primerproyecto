using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject : MonoBehaviour
{
    private float speed = 1f;
    private float turnSpeed = 70f;
    private float horizontalInput;
    private float verticalInput;
    /*
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        PlayerInBounds();
       
    }
    */
    private void Update()
    {

        //detectar imputhorizontal
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // movimiento hacia adelante
        // transform.Translate(0, 0, 1); 
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        //movimiento lateral manual
        //transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
    /*
    private void PlayerInBounds()
    {
        Vector3 pos = transform.position;
        if (pos.x < -xRange)
        {
            transform.position = new Vector3(-xRange, pos.y, pos.z);
        }
        if (pos.x > xRange)
        {
            transform.position = new Vector3(xRange, pos.y, pos.z);
        }
        if (pos.y < -xRange)
        {
            transform.position = new Vector3(-xRange, pos.x, pos.z);
        }
        if (pos.y > xRange)
        {
            transform.position = new Vector3(xRange, pos.x, pos.z);
        }
    }
    */
}

