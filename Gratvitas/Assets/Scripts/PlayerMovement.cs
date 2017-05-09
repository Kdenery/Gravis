using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    // public VirtualJoystick joystick;

    public float speed;
	bool ready = false;

    private Rigidbody rb;
	GameObject camera;
	GameObject joystick;
	VirtualJoystick joystickscript;
	Vector3 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
		camera = GameObject.FindGameObjectWithTag ("MainCamera");

		joystick = GameObject.Find ("bgImage");
		joystickscript = joystick.GetComponent<VirtualJoystick> ();

    }

	void Update ()
	{


            if (transform.position.y < camera.transform.position.y || ready == true) {
			ready = true;

		if (Input.GetKey("space"))
		{
			int thisScene = SceneManager.GetActiveScene ().buildIndex;
			SceneManager.LoadScene(thisScene);
		}
            

   
                if (Input.GetKey("escape"))
            
			{
				SceneManager.LoadScene(0);
			}

			camera.transform.position = new Vector3 (transform.position.x * 0.5f, (transform.position.y * 0.3f) + 4.5f, transform.position.z - 8);
			//camera.transform.LookAt (gameObject.transform)}
		}
	}

    public Rigidbody Player;
    void OnTriggerEnter(Collider collision)
    {
        Player = GetComponent<Rigidbody>();


        if (collision.gameObject.tag == "DeathBox")
        {
            int thisScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(thisScene);
        }
        if (collision.gameObject.tag == "Jump")
        {

            Player.AddForce(0, 500, 0);
            }
        if (collision.gameObject.tag == "RotatePlayer")
        {

            Player.AddRelativeForce(0, 500, 0);
            Player.AddRelativeTorque(0, 0, 25);
            
        }
        if (collision.gameObject.tag == "RelativeFlip")
        {

            Player.transform.Rotate(0, 0, 180, Space.Self);

        }

    }
    

            void FixedUpdate()
    {
       // float moveHorizontal = Input.GetAxis("Horizontal");
       // float moveVertical = Input.GetAxis("Vertical");

		movement = new Vector3 (joystickscript.Horizontal (), 0, joystickscript.Vertical ()); 

        // Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddRelativeForce(movement * speed);
    }
}