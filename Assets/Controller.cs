using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    [SerializeField] Vector2 playerInput;
    Rigidbody2D rb;

    public float movSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (gameStates.noControl)
        {

            if (Input.GetKeyDown(KeyCode.E) && gameStates.noE == false)
            {
                Debug.Log("Use");
            }
            if (Input.GetKeyDown(KeyCode.F) && gameStates.noF == false)
            {
                Debug.Log("Attack");
            }
        }
    }

    void FixedUpdate()
    {
        if (gameStates.noControl)
        {

            playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

            if (gameStates.noA)
            {
                if (playerInput.x == -1)
                {
                    movSpeed = 0;
                }
                else
                {
                    movSpeed = 6;
                }
            }

            if (gameStates.noD)
            {
                if (playerInput.x == 1)
                {
                    movSpeed = 0;
                }
                else
                {
                    movSpeed = 6;
                }
            }

            if (gameStates.noW)
            {
                if (playerInput.y == 1)
                {
                    movSpeed = 0;
                }
                else
                {
                    movSpeed = 6;
                }
            }

            if (gameStates.noS)
            {
                if (playerInput.y == -1)
                {
                    movSpeed = 0;
                }
                else
                {
                    movSpeed = 6;
                }
            }

            rb.velocity = playerInput.normalized * movSpeed;
        }
    }
}

