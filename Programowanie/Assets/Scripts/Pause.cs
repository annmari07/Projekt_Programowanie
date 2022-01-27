using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject pauseMenu;

    private void Start()
    {
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) == true)
        {
           pauseMenu.SetActive(true);

        }

    }


    public void OneResumeClicked()
    {
        
    }

    public void OneMenuClicked()
    {
        
    }
}
