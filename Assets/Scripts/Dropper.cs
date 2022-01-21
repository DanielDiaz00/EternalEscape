using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    //Creamos la variable para llamar a estos 2
    MeshRenderer renderer; 
    Rigidbody rigidbody;
    [SerializeField] float timeToWait = 5f; //El tiempo de espera lo podemos modificar en el editor
    
    // Start is called before the first frame update
    void Start()
    {
        //Permite guardar en una variable los accesos al rigidbody y modificar su fisica y al meshrenderer para desaperecer
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        //Si el tiempo aun no se cumplio ponemos false que desaperece el obstaculo y la fisica
        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {   
        //Si el tiempo se cumplio que aparezca el obstaculo y la fisica fluya
        if(Time.time > timeToWait)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
