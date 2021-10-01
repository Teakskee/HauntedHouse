using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceScript : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Path0DialogueOptionChoice1; //Path 0 is the initial dialogue
    public GameObject Path0DialogueOptionChoice2;

    //public GameObject Path1DialogueOptionChoice1;
    //public GameObject Path1DialogueOptionChoice2;

    //public GameObject Path2DialogueOptionChoice1;
    //public GameObject Path2DialogueOptionChoice2;
    //public GameObject Path2DialogueOptionChoice3;

    public int ChoiceMade;

    public void Path0DialogueChoiceOption1() //Path 1 Starts
    {
        TextBox.GetComponent<Text>().text = "Ooh you can't outrun it.  It comes after you, it grabs you and you die. ";
        ChoiceMade = 1; //path variable number
    }

    public void Path0DialogueChoiceOption2() //if select first option from path 1, the Lone NPC replies                                                this. 
    {
        TextBox.GetComponent<Text>().text = "Yeah good job, the beast is hurt. You are safe for now..";
        ChoiceMade = 2;
    }

    //public void Path1DialogueChoiceOption2()
    //{
    //    TextBox.GetComponent<Text>().text = "The creator of this world obviously. However, I'm not really the creator.";
    //    ChoiceMade = 5;
    //}

    //public void Path1DialogueChoiceOption3()
    //{
    //    TextBox.GetComponent<Text>().text = "Come on say something";
    //    ChoiceMade = 6;
    //}

    //public void Path0DialogueChoiceOption2() // Path 2 starts
    //{
    //    TextBox.GetComponent<Text>().text = "I believe its obvious to you. After all, you were purposefully created to say it.";
    //    ChoiceMade = 2;
    //}

    //public void Path0DialogueChoiceOption3() // Path 3 starts
    //{
    //    TextBox.GetComponent<Text>().text = "Nothing to say? You must be confused aren't you.";
    //    ChoiceMade = 3;
    //}

    // Update is called once per frame

    void Update()
    {
        if (ChoiceMade >= 0)
        {
            Path0DialogueOptionChoice1.SetActive(true);
            Path0DialogueOptionChoice2.SetActive(true); //activation and deactivation of options when pressed

            //Path1DialogueOptionChoice1.SetActive(false);
            //Path1DialogueOptionChoice2.SetActive(false);
        }

        //if (ChoiceMade == 1)
        //{
        //    Path1DialogueOptionChoice1.SetActive(true);
        //    Path1DialogueOptionChoice2.SetActive(true);
        //    //Path1DialogueOptionChoice3.SetActive(true);

        //    Path0DialogueOptionChoice1.SetActive(false);
        //    Path0DialogueOptionChoice2.SetActive(false);
        //    //Path0DialogueOptionChoice3.SetActive(false);
        //}
    }
}