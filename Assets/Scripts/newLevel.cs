using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newLevel : MonoBehaviour
{
    public GameObject endUI;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Time.timeScale = 0f;
        endUI.SetActive(true);
    }

}
