using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gonext : MonoBehaviour
{
    public GameObject TextBox1;
    public GameObject Option1;
    public int Clicked0;

    public void Clicked()
    {
        TextBox1.GetComponent<Text>().text = "We are here for Now !";
        Clicked0 = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Clicked0 >= 1)
        {
            Option1.SetActive(false);
        }
        
    }
}
