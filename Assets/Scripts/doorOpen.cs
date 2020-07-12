using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour
{
    public int keyToOpen;
    
    private void Update()
    {
        if(gameStates.key == keyToOpen)
        {
            Destroy(gameObject);
        }
    }
}
