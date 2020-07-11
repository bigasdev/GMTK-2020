using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usableThings : MonoBehaviour
{
    public bool onDoor;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            onDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
            onDoor = false;
    }


    public void Open()
    {
        Destroy(gameObject);
    }
}
