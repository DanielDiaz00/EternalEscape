using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public enum Levels { Menu = 0, Level1 = 1, Level2 = 2, Level3 = 3, Level4 = 4, Level5 = 5, End = 6}


    public void ChangeLevel(Levels level)
    {
        //Permite cambiar de escena
        SceneManager.LoadScene((int)level);
    }

    public void ChangeLevel(int index)
    {
        SceneManager.LoadScene(index);
    }    

    public void Quit()
    {
        //Sale del juego
        Application.Quit();
    }
    
    
        
    
}
