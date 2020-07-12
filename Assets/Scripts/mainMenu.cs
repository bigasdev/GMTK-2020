using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public GameObject logo;
    public GameObject MainMenu;
    public GameObject creditsMenu;
    public AudioSource click;
    public void Play()
    {
        SceneManager.LoadScene(1);
        logo.SetActive(false);
    }

    public void Music()
    {
        if(musicState.isMuted == true)
        {
            musicState.isMuted = false;
        }
        else
        {
            musicState.isMuted = true;
        }
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

    public void Click()
    {
        click.Play();
    }
}
