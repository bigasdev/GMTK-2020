using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public bool isKey;
    public bool isDiamond;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(isKey)
            {
                gameStates.key += 1;
                Destroy(gameObject);
            }

            if(isDiamond)
            {
                gameStates.respawned = true;
                Destroy(gameObject);
            }
        }
    }
}
