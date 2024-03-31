using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Vector3 startPosition;

    public Vector2 speed = new Vector2(50, 50);

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Horizontal input & speed control
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");


        Vector3 movement = new Vector3(speed.x * inputX, 0, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "OOB")
        {
            transform.position = startPosition;

        }
        if (other.tag == "Finish")
        {
            transform.position = startPosition;

        }

    }

}