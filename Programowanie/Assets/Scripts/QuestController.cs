using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestController : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger enter " + other.gameObject.name);
        SnowmanNPC npc = other.gameObject.GetComponent<SnowmanNPC>();

        if(npc != null)
            
            {

            npc.ShowUI();

            }

    }

    private void OnTriggerExit(Collider other)
    {
        SnowmanNPC npc = other.gameObject.GetComponent<SnowmanNPC>();

        if (npc != null)

        {

            npc.HideUI();

        }


    }

}
