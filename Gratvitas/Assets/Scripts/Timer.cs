using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    public bool finished = false;

    // Use this for initialization
    void Start()
    {
        startTime = Time.time;

		if (GameObject.FindGameObjectsWithTag ("TimerCanvas").Length > 1) {
			Destroy(GameObject.FindGameObjectsWithTag ("TimerCanvas")[1]);
		}
			
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;

	if (finished) {
			GameObject.Destroy (transform.parent.gameObject);
		}
    }


    public void Finish()
    {
        finished = true;
        timerText.color = Color.yellow;
    }
}