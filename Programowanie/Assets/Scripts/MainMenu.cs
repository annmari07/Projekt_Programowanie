using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public AudioClip mouseClickClip;
    public AudioSource audioSource;


    public void OnStartClicked()
    {
        Debug.Log("Start clicked");
        audioSource.PlayOneShot(mouseClickClip);

        SceneManager.LoadScene("Level_01");
    }

    
    public void OnQuickClicked()
    {
        Debug.Log("Start clicked");
        audioSource.PlayOneShot(mouseClickClip);
        Application.Quit();
    }
}
