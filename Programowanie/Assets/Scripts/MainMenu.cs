using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void OnStartClicked()
    {
        Debug.Log("Start clicked");
        SceneManager.LoadScene("Level_01");
    }

    
    public void OnQuickClicked()
    {
        Debug.Log("Start clicked");
    }
}
