using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back2Menu : MonoBehaviour
{

   
    public void Menu()
    {
        
        {
         SceneManager.LoadScene(1);
        }

    }

    public void PressStart()
    {
        SceneManager.LoadScene(0);
    }

}

 
