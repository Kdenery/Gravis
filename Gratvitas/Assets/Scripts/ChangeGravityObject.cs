using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravityObject : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}


	void OnTriggerEnter(Collider collision)
	{
        if (collision.gameObject.tag == "HGravButton") {

            ConstantForce boxForce = GameObject.FindGameObjectWithTag("HGravBox").GetComponent<ConstantForce>();

            if (boxForce.force.y != 0) 
            {

                boxForce.force = new Vector3(0, 0, 25);
                }
                else {
                boxForce.force = new Vector3(0, -25, 0);
                }

    }
        

		if (collision.gameObject.tag == "GravityButton") {
			//steps on button
			ConstantForce boxForce = GameObject.FindGameObjectWithTag("GravityBox").GetComponent<ConstantForce>();
				boxForce.force = boxForce.force * -1;
		}

        if (collision.gameObject.tag == "-XGravButton")
        {

            ConstantForce boxForce = GameObject.FindGameObjectWithTag("-XGravBox").GetComponent<ConstantForce>();

            if (boxForce.force.y != 0)
            {

                boxForce.force = new Vector3(-25, 0, 0);
            }
            else
            {
                boxForce.force = new Vector3(0, -25, 0);
            }

        }

    }
}