using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour {
    public AudioClip clip;
    public AudioSource energy;
    public AudioSource chill;

    private bool calm;

    // Use this for initialization
    public void Awake () {
        chill = GameObject.Find("Chilll").GetComponent<AudioSource>();
        energy = GameObject.Find("Energy").GetComponent<AudioSource>();

        calm = true;
    
	}
  
    void update () {
 


        int thisScene = SceneManager.GetActiveScene().buildIndex;
        if (thisScene == 0 || thisScene == 13)
        {
            calm = true;
        }
        else
        {
            calm = false;
        }



        if (calm == true)
        {
            chill.volume = 1f;
            energy.volume = 0f;
        }
        
        if (calm == false)
        {
            energy.volume = 1f;
            chill.volume = 0f;
        }
	}
}
