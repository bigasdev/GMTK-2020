using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseButtons : MonoBehaviour
{
    public int room;
    public GameObject pauseUI;
    
    public void Resume()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        SceneManager.LoadScene(room);
        Time.timeScale = 1f;
        gameStates.restarted = true;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
