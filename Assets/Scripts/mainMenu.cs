using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public GameObject logo;
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

    }

    public void Quit()
    {
        Application.Quit();
    }
}
