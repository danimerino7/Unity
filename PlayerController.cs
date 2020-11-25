using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 10.0f;
    public GameObject proyectilComida;

    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float movimientovertical = Input.GetAxis("Vertical") * speed;
        float movimientohorizontal = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        movimientovertical *= Time.deltaTime;
        movimientohorizontal *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, 0, movimientovertical);

        // Rotate around our y-axis
        transform.Translate(movimientohorizontal, 0,0);

        //disparar carne

        if (Input.GetKeyDown(KeyCode.Space)) {

            Instantiate(proyectilComida, transform.position, transform.rotation);
        }




    }
}

