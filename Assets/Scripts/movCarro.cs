using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movCarro : MonoBehaviour
{
    public Renderer carro;
    private bool isMovingLeft = false;
    private bool isMovingRight = false;
    private bool isMovingTop = false;
    private bool isMovingBottom = false;
    private float velocidadMovimiento = 0.04f;    void Start()
    {
        carro.transform.position = new Vector3(0, -3.2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            isMovingRight = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            isMovingLeft = true;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            isMovingRight = false;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            isMovingLeft = false;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            isMovingTop = true;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            isMovingBottom = true;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            isMovingTop = false;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            isMovingBottom = false;
        }

        if (isMovingLeft)
        {
            carro.transform.position = carro.transform.position + new Vector3(-velocidadMovimiento, 0);
        }

        if (isMovingRight)
        {
            carro.transform.position = carro.transform.position + new Vector3(velocidadMovimiento, 0);
        }

        if (isMovingTop)
        {
            carro.transform.position = carro.transform.position + new Vector3(0, velocidadMovimiento);
        }

        if (isMovingBottom)
        {
            carro.transform.position = carro.transform.position + new Vector3(0, -velocidadMovimiento);
        }
    }
        
    
}
