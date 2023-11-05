using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverUI;

    public GameObject jugador;
    public GameObject RespawnPoint;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void gameOver()
    {
        GameOverUI.SetActive(true);
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Reintentar");
    }
    public void Menu()
    {
        SceneManager.LoadScene("MenuPrincipal");
        Debug.Log("Menu");
    }
    public void Salir()
    {
        Application.Quit();
        Debug.Log("Salir");
    }
}
