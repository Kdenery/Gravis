using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    private bool activated = false;

    public float speed = 0.05f;
    GameObject Frame;

    void Update()
    {
        if (activated == true)
        {
            Transform Frame = GameObject.FindGameObjectWithTag("Frame").GetComponent<Transform>();

            Frame.transform.Rotate((0), (0), (-1f));
        }
    }


    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "RotateButton")
        {
            if (activated == false)
            {
                activated = true;
            }
            else
            {
                activated = false;
            }
        }
    }
}