using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFailed : MonoBehaviour
{    
  
    private void OnCollisionEnter(Collision other) 
    {
        //Si chocamos con un obstaculo este se cambiara de color
        if(other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Failed";
        }
    }

    
    
}
