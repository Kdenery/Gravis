using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindAndSetTime : MonoBehaviour {

	Timer currentTimer;
	Text finalText;

	// Use this for initialization
	void Start () {
		finalText = GetComponent<Text> ();
		currentTimer = GameObject.Find ("Timer Text").GetComponent<Timer> ();
		finalText.text = currentTimer.timerText.text;
		currentTimer.finished = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
