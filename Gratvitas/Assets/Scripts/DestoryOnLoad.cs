using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOnLoad : MonoBehaviour
{
    GameObject music;
     Timer currentTimer;
    // Use this for initialization
    void Start()
    {
        currentTimer = GameObject.Find("Timer Text").GetComponent<Timer>();
        currentTimer.finished = true;

        music = GameObject.Find("Musicc");

    }
}