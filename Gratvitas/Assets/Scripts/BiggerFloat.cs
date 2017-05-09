using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiggerFloat : MonoBehaviour {


    float xVel = Random.Range(-90, 50);
    float yVel = Random.Range(-50, 50);
    float zVel = Random.Range(-90, 90);

    float xSpin = Random.Range(-50, 400);
    float ySpin = Random.Range(-500, 400);
    float zSpin = Random.Range(-200, 500);


    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {




        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x == 0 && rb.velocity.y == 0)
        {
            rb.AddRelativeTorque(xSpin / 5, ySpin / 5, zSpin /5);

            rb.AddRelativeForce(xVel / 20, yVel / 20, zVel / 20, ForceMode.Impulse);
        }

    }
}
