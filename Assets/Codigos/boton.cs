using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class boton : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene() .buildIndex +  1);
    }
    public void Salir()
    {
        Debug.Log("Salir");
        Application.Quit();
    }
    
}
