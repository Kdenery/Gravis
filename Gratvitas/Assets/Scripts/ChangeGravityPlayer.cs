using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravityPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider collision) {

        if (collision.gameObject.tag == "HPGravButton")
        {
            ConstantForce playerForce = gameObject.GetComponent<ConstantForce>();

            if (playerForce.force.y != 0)
            {
                playerForce.force = new Vector3(0, 0, 25);
                }
                 else{
                playerForce.force = new Vector3(0, -25, 0);
            }
        }

		if (collision.gameObject.tag == "PlayerGravity") {
			//steps on button
			ConstantForce playerForce = gameObject.GetComponent<ConstantForce>();
			playerForce.force = playerForce.force * -1;
            playerForce.relativeForce = playerForce.relativeForce * -1;
        }

//		if (collision.gameObject.tag == "anythin") {
//			//steps on button
//		ConstantForce boxForce = GameObject.FindGameObjectWithTag("GravityBox").GetComponent<ConstantForce>();
//		boxForce.force = boxForce.force * -1;
//		}
	}

}
