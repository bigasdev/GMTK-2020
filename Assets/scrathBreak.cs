using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrathBreak : MonoBehaviour
{
    public bool onScratch;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            onScratch = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        onScratch = false;
    }

    public void Break()
    {
        Destroy(gameObject);
    }
}


