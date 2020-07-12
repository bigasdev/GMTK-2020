using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicState : MonoBehaviour
{
    public static bool isMuted;
    public AudioSource music;

    private void Update()
    {
        if(isMuted == true)
        {
            music.volume = 0;
        }
        else
        {
            music.volume = .5f;
        }

    }
}
