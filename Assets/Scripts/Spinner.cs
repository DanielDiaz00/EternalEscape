using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    //En el editor lo modificamos al y y le pusimos 0.5 para que gire en circulo
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 0;
    [SerializeField] float zAngle = 0;
    
    // Update is called once per frame
    void Update()
    {
        //Rote de manera permanente
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
