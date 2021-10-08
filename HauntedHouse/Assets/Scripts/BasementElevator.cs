using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasementElevator : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Stairs;
    public GameObject Elevator;
    public GameObject PlayAgain;
    public int Choice;

    void Start()
    {
        PlayAgain.SetActive(false);
    }

    public void GoStairs()
    {
        TextBox.GetComponent<Text>().text = "Damn u fell through the stairs and died, dumb you.";
        Choice = 1;
    }

    public void GoElevator()
    {
        TextBox.GetComponent<Text>().text = "Oooh no, you didn't kill the beast after all. With his sharp teeth he bites in the cables of the elevator and u still fall to your death.";
        Choice = 2;
    }


    void Update()
    {
        if(Choice >= 1)
        {
            Stairs.SetActive(false);
            Elevator.SetActive(false);
            PlayAgain.SetActive(true);
        }
    }
}
