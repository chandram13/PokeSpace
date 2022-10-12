using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            this.rotationSpeed = 10;

        }
        else
        {
            this.rotationSpeed = 50;
        }

        transform.RotateAround(Vector3.zero, Vector3.forward, Time.deltaTime * this.rotationSpeed);
      
    }
}