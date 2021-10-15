using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 1stfloor : MonoBehaviour
{


    public GameObject TextBox;
public GameObject basement;
public GameObject door;
public GameObject 2stfloor;
public GameObject NextAfterWeapon1;
public GameObject NextAfterWeapon2;
public GameObject NextAfterWeapon3;
public int keuze;

void Start()
{
    NextAfterWeapon1.SetActive(false);
    NextAfterWeapon2.SetActive(false);
    NextAfterWeapon3.SetActive(false);
}



public void Getbasement ()
{
    TextBox.GetComponent<Text>().text = "Damn you killed that foul beast fast. Maybe you will survive this after all!?";
    Choice = 1;
}

public void Getdoor()
{
    TextBox.GetComponent<Text>().text = "The beast stares at u with a blank stare knowing u made a dumb decision. He smacks the mop out ur hand and eats you.";
    Choice = 2;
}

public void Get2stfloor()
{
    TextBox.GetComponent<Text>().text = "TBQ";
    Choice = 3;
}

void Update()
{

    if (Choice >= 1)
    {
        Weapon1.SetActive(false);
        Weapon2.SetActive(false);
        Weapon3.SetActive(false);
    }
    if (Choice == 1)
    {
        NextAfterWeapon1.SetActive(true);
    }
    else if (Choice == 2)
    {
        NextAfterWeapon2.SetActive(true);
    }
    else if (Choice == 3)
    {
        NextAfterWeapon3.SetActive(true);
    }

}
}

}
