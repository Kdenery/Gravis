using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButton: MonoBehaviour
{
    public GameObject music;
    Timer currentTimer;
   public void OnButtonClick()
{
        SceneManager.LoadScene(0);
        currentTimer = GameObject.Find("Timer Text").GetComponent<Timer>();
        currentTimer.finished = true;

        music = GameObject.Find("Musicc");
        Destroy(music);


    }
}