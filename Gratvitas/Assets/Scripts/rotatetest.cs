using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatetest : MonoBehaviour
{
    public float speed = 0.01f;

    void Update()
    {
        transform.Rotate((1f), (0), (0));
    }
}