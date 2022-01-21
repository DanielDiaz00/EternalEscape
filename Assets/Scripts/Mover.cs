using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //Variable para moverse a cierta velocidad
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update() 
    {
        MovePlayer();
    }

    void PrintInstructions() 
    {
        //Los mensajes que recibira el jugador al iniciar el juego
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        //Permite mover al jugador de manera horizontal y vertical con el teclado
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }

}
