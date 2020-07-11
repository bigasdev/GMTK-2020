using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseButtons : MonoBehaviour
{
    public int room;
    
    public void Resume()
    {
        pauseMenu.gamePaused = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(room);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
