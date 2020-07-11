using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endButtons : MonoBehaviour
{
    public int nextRoom;
    public int actualRoom;
    public GameObject endUI;

    public void Restart()
    {
        SceneManager.LoadScene(actualRoom);
        Time.timeScale = 1f;
        endUI.SetActive(false);
        gameStates.restarted = true;
    }

    public void Next()
    {
        SceneManager.LoadScene(nextRoom);
        Time.timeScale = 1f;
        gameStates.restarted = true;
    }
}
