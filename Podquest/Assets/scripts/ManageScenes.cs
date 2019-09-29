using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManageScenes : MonoBehaviour
{
    public GameObject MenuPrincipal;
    public GameObject Credits;


    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void EnableCredits()
    {
        MenuPrincipal.SetActive(false);
        Credits.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Return()
    {
        Credits.SetActive(false);
        MenuPrincipal.SetActive(true);
    }
}
