using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Life : MonoBehaviour
{
    public GameObject[]  hearts;

    int life = 0;

    private void OnCollisionEnter(Collision other) 
    {
        //Cada vez que choquemos con un obstaculo perdemos una vida
        if(other.gameObject.tag != "Failed")
        {
            life++;
        }

        if (life == 3)
        {
            Debug.Log("Fallaste");
            Destroy(hearts[0].gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (life == 2)
        {
            Debug.Log("Tienes 1 vida");
            Destroy(hearts[1].gameObject);
        }
        else if (life == 1)
        {
            Debug.Log("Tienes 2 vidas");
            Destroy(hearts[2].gameObject);
        }
    }
}
