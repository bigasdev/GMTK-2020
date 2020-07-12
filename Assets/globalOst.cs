using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalOst : MonoBehaviour
{
    private GameObject[] globals;
    private GameObject[] globalSf;
    
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        globals = GameObject.FindGameObjectsWithTag("GlobalOST");
        globalSf = GameObject.FindGameObjectsWithTag("Global");

        if(globals.Length > 1)
        {
            Destroy(globals[1]);
        }

        if(globalSf.Length > 1)
        {
            Destroy(globalSf[1]);
        }
    }
}
