using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStates : MonoBehaviour
{
    [Header("bolleans")]
    public static bool noA;
    public static bool noW;
    public static bool noS;
    public static bool noD;
    public static bool noE;
    public static bool noF;
    public static bool noControl;
    public static int key;
    public static bool restarted;
    public static bool respawned;

    private void Update()
    {
        if(restarted)
        {
            Restart();
        }
        if(respawned)
        {
            Reseta();
        }
    }

    public void Restart()
    {
        noA = false;
        noD = false;
        noS = false;
        noW = false;
        noE = false;
        noF = false;
        noControl = false;
        key = 0;
        restarted = false;
    }

    public void Reseta()
    {
        noA = false;
        noD = false;
        noS = false;
        noW = false;
        noE = false;
        noF = false;
        noControl = false;
        respawned = false;
    }
}
