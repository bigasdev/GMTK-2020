using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public SpriteRenderer limit;
    void Start()
    {
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float targetRatio = limit.bounds.size.x / limit.bounds.size.y;

        if (screenRatio >= targetRatio)
        {
            Camera.main.orthographicSize = limit.bounds.size.y / 2;
        }
        else
        {
            float differenceInSize = targetRatio / screenRatio;
            Camera.main.orthographicSize = limit.bounds.size.y / 2 * differenceInSize;
        }
    }
}
