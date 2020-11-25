using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfLimits : MonoBehaviour
{
    // Start is called before the first frame update

    public float topbound = 30;
    public float lowerbound = -15;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //destructor de objetos
        if(transform.position.z > topbound)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < lowerbound)
        {
            Destroy(gameObject);
        }

    }
}
