using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public GameObject logo;
    public GameObject MainMenu;
    public GameObject creditsMenu;
    public void Play()
    {
        SceneManager.LoadScene(1);
        logo.SetActive(false);
    }

    public void Level()
    {

    }

    public void Credits()
    {
        creditsMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void Back()
    {
        creditsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
