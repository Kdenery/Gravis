using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFloat : MonoBehaviour {


    public float yv;
    public float zs;



    float xVel = Random.Range(-50, 50);
    float yVel = Random.Range(-50, 50);
    float zVel = Random.Range(-50, 50);

    float xSpin = Random.Range(-50, 50);
    float ySpin = Random.Range(-50, 50);
    float zSpin = Random.Range(-50, 50);


    public Rigidbody rb;

    // Use this for initialization
    void Start () {

    


        rb = GetComponent<Rigidbody>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (rb.velocity.x == 0 && rb.velocity.y == 0) {
            rb.AddRelativeTorque(xSpin/500  , ySpin/500  , zSpin/500  );
  
            rb.AddRelativeForce(xVel/1200  , yVel/1200  , zVel/1600  , ForceMode.Impulse);
        }
       
    }
}
