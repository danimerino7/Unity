using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //  transform.position += Vector3.back * Time.deltaTime * speed;
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
    }
}
