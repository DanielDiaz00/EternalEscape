using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishOnTriggerEnter : MonoBehaviour
{
    private void OnTriggerEnter(Collider finish) {
        if (finish.gameObject.tag == "Player")
        {
            //Si colisiono con el objeto llamado finish cambiar de nivel
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
