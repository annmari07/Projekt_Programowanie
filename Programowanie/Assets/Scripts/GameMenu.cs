using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{

    public GameObject pauseMenu;


    private void Start()
    {
        pauseMenu.SetActive(false);

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) == true)
           
        {
            pauseMenu.SetActive(true);
                
        }



    }




    public void OnResumeClicked()
    {
        
    }

    
    public void OnBackToMenuClicked()
    {
        
    }
}
