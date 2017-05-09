using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LNL : MonoBehaviour
{
    [SerializeField] private string loadLevel;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
			int thisScene = SceneManager.GetActiveScene ().buildIndex;
            SceneManager.LoadScene(thisScene + 1);
        }
    }
}