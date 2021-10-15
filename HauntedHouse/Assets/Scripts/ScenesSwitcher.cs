using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesSwitcher : MonoBehaviour
{
    public int Start = 0;

    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void ChooseWeapon()
    {
        SceneManager.LoadScene("BasementOptional1");
    }

    public void Reset()
    {
        SceneManager.LoadScene("Start");
    }

    public void RightDoor()
    {
        SceneManager.LoadScene("RightDoor");
    }

    public void Run()
    {
        SceneManager.LoadScene("Run");
    }

    public void Attack()
    {
        SceneManager.LoadScene("Attack");
    }

    public void Knife()
    {
        SceneManager.LoadScene("BasementVraag2");
    }

    public void Chainsaw()
    {
        SceneManager.LoadScene("Chainsaw");
    }

    public void Mop()
    {
        SceneManager.LoadScene("Mop");
    }

    public void Elevator()
    {
        SceneManager.LoadScene("BasementElevator");
    }

    public void StartToBasement()
    {
        SceneManager.LoadScene("BasementText1");
    }

    public void DeathByStairs()
    {
        SceneManager.LoadScene("DeathByStairs");
    }

    public void DeathByElevator()
    {
        SceneManager.LoadScene("DeathByElevator");
    }

    public void DeathByArrow()
    {
        SceneManager.LoadScene("DeathByArrow");
    }

    public void FirstFloorDoor()
    {
        SceneManager.LoadScene("1stFloorDoor");
    }


    public void FirstFloorForward()
    {
        SceneManager.LoadScene("1stFloorForward");
    }

    public void FirstFloorVraag()
    {
        SceneManager.LoadScene("1stFloorVraag");
    }

    public void StartVraag()
    {
        SceneManager.LoadScene("StartVraag");
    }
}
