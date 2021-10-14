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
}