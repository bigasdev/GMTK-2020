using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cursosPlace : MonoBehaviour
{
    private SpriteRenderer opacity;
    public GameObject pointer;
    public LayerMask button;
    private Vector2 cursorPos;
    private SpriteRenderer colorChange;
    public pauseMenu ps;
    public int room;


    public void Start()
    {
        opacity = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        RaycastHit2D restart = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, button);

        if(restart)
        {
            if (restart.collider.tag == "Restart")
            {
                opacity.color = new Color(1f, 1f, 1f, 1f);

                cursorPos = restart.collider.gameObject.transform.position;
                pointer.transform.position = new Vector2(cursorPos.x, cursorPos.y);
                colorChange = restart.collider.GetComponent<SpriteRenderer>();

                if (Input.GetButton("Fire1"))
                {
                    gameStates.restarted = true;
                    SceneManager.LoadScene(room);                   
                }
            }

            if (restart.collider.tag == "Bag")
            {
                opacity.color = new Color(1f, 1f, 1f, 1f);

                cursorPos = restart.collider.gameObject.transform.position;
                pointer.transform.position = new Vector2(cursorPos.x, cursorPos.y);
                colorChange = restart.collider.GetComponent<SpriteRenderer>();

                if (Input.GetButton("Fire1"))
                {
                    ps.Pause();
                }
            }
        }


        if (gameStates.noControl == false && pauseMenu.gamePaused == false)
        {

            opacity.color = new Color(0f, 0f, 0f, 0f);

            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, button);

            if (hit)
            {
                if (hit.collider.tag == "Button")
                {
                    opacity.color = new Color(1f, 1f, 1f, 1f);

                    cursorPos = hit.collider.gameObject.transform.position;
                    pointer.transform.position = new Vector2(cursorPos.x, cursorPos.y);
                    colorChange = hit.collider.GetComponent<SpriteRenderer>();

                    if (Input.GetButton("Fire1"))
                    {
                        gameStates.noW = true;
                        gameStates.noControl = true;
                        colorChange.color = new Color(0f, 0f, 0f, 1f);
                    }

                }

                if (hit.collider.tag == "A")
                {
                    opacity.color = new Color(1f, 1f, 1f, 1f);

                    cursorPos = hit.collider.gameObject.transform.position;
                    pointer.transform.position = new Vector2(cursorPos.x, cursorPos.y);
                    colorChange = hit.collider.GetComponent<SpriteRenderer>();

                    if (Input.GetButton("Fire1"))
                    {
                        gameStates.noA = true;
                        gameStates.noControl = true;
                        colorChange.color = new Color(0f, 0f, 0f, 1f);
                    }
                }

                if (hit.collider.tag == "S")
                {
                    opacity.color = new Color(1f, 1f, 1f, 1f);

                    cursorPos = hit.collider.gameObject.transform.position;
                    pointer.transform.position = new Vector2(cursorPos.x, cursorPos.y);
                    colorChange = hit.collider.GetComponent<SpriteRenderer>();

                    if (Input.GetButton("Fire1"))
                    {
                        gameStates.noS = true;
                        gameStates.noControl = true;
                        colorChange.color = new Color(0f, 0f, 0f, 1f);
                    }
                }

                if (hit.collider.tag == "D")
                {
                    opacity.color = new Color(1f, 1f, 1f, 1f);

                    cursorPos = hit.collider.gameObject.transform.position;
                    pointer.transform.position = new Vector2(cursorPos.x, cursorPos.y);
                    colorChange = hit.collider.GetComponent<SpriteRenderer>();

                    if (Input.GetButton("Fire1"))
                    {
                        gameStates.noD = true;
                        gameStates.noControl = true;
                        colorChange.color = new Color(0f, 0f, 0f, 1f);
                    }
                }

                if (hit.collider.tag == "E")
                {
                    opacity.color = new Color(1f, 1f, 1f, 1f);

                    cursorPos = hit.collider.gameObject.transform.position;
                    pointer.transform.position = new Vector2(cursorPos.x, cursorPos.y);
                    colorChange = hit.collider.GetComponent<SpriteRenderer>();

                    if (Input.GetButton("Fire1"))
                    {
                        gameStates.noE = true;
                        gameStates.noControl = true;
                        colorChange.color = new Color(0f, 0f, 0f, 1f);
                    }
                }

                if (hit.collider.tag == "F")
                {
                    opacity.color = new Color(1f, 1f, 1f, 1f);

                    cursorPos = hit.collider.gameObject.transform.position;
                    pointer.transform.position = new Vector2(cursorPos.x, cursorPos.y);
                    colorChange = hit.collider.GetComponent<SpriteRenderer>();

                    if (Input.GetButton("Fire1"))
                    {
                        gameStates.noF = true;
                        gameStates.noControl = true;
                        colorChange.color = new Color(0f, 0f, 0f, 1f);
                    }
                }
            }


            if(gameStates.noControl == true)
            {
                opacity.color = new Color(0f, 0f, 0f, 0f);
            }
        }
    }
}
