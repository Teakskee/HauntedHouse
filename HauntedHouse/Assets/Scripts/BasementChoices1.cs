using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasementChoices1 : MonoBehaviour
{

    public GameObject TextBox;
    public GameObject Weapon1;
    public GameObject Weapon2;
    public GameObject Weapon3;
    public int Choice;
    
    public void GetWeapon1()
    {
        TextBox.GetComponent<Text>().text = "Damn you killed that foul beast fast. Maybe you will survive this after all!?";
        Choice = 1;
    }

    public void GetWeapon2()
    {
        TextBox.GetComponent<Text>().text = "The beast stares at u with a blank stare knowing u made a dumb decision. He smacks the mop out ur hand and eats you.";
        Choice = 2;
    }

    public void GetWeapon3()
    {
        TextBox.GetComponent<Text>().text = "TBQ";
        Choice = 3;
    }

    void Update()
    {
        if(Choice >= 1)
        {
            Weapon1.SetActive(false);
            Weapon2.SetActive(false);
            Weapon3.SetActive(false);
        }
    }
}
