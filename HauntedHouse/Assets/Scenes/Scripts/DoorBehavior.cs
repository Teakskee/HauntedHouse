using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour
{
    public void open()
    {
        myDoor.Play("OpenDoor", 0, 0.0f); 
        gameObject.SetActive(false);
    }

    public void open1()
    {
        myDoor.Play("opendoor1", 0, 0.0f);
        gameObject.SetActive(false);
    }

    public void openLeftDoor()
    {
        myDoor.Play("OpenLeftDoor", 0, 0.0f);
        gameObject.SetActive(false);
    }

    public void OpenrightDoor()
    {
        myDoor.Play("OpenRightDoor", 0, 0.0f);
        gameObject.SetActive(false);
    }

    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                myDoor.Play("OpenDoor",0, 0.0f);
                gameObject.SetActive(false);
            }
            else if (closeTrigger)
            {
                myDoor.Play("CloseDoor", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }

    
}
