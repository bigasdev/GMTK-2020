using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPatrol : MonoBehaviour
{
    public bool onGuard;
    public bool patrolling;
    public float speed;
    public Transform[] moveSpots;
    private int randomSpot;

    private float waitTime;
    public float startTime = 2f;

    private void Start()
    {
        waitTime = startTime;
        randomSpot = Random.Range(0, moveSpots.Length);
    }

    private void Update()
    {
        if (patrolling == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed);

            if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
            {
                if(waitTime <= 0)
                {
                    randomSpot = Random.Range(0, moveSpots.Length);
                    waitTime = startTime;
                }
                else
                {
                    waitTime -= Time.deltaTime;
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            onGuard = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        onGuard = false;
    }


    public void Attack()
    {
        Destroy(gameObject);
    }
}
