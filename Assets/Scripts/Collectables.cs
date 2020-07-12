using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public bool isKey;
    public bool isDiamond;
    private GameObject keySound;
    private AudioSource keyS;

    private void Update()
    {
        keySound = GameObject.Find("KeyPick");
        keyS = keySound.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(isKey)
            {
                gameStates.key += 1;
                keyS.Play();
                Destroy(gameObject);
            }

            if(isDiamond)
            {
                gameStates.respawned = true;
                keyS.Play();
                Destroy(gameObject);
            }
        }
    }
}
