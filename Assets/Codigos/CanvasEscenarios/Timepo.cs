using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timepo : MonoBehaviour
{
    private TMP_Text textComponent;
    private int puntuacion = 0;
    public TMP_Text Puntos;
    public GameObject[] vidas;
    void Start()
    {
        textComponent = GetComponent<TMP_Text>();
    }



    void Update()
    {
        textComponent.text = "Puntuacion:" + puntuacion;


    }
    public void AddPoints(int value)
    {
        puntuacion = puntuacion + value;
    }



    public void ActualizarPuntos(int puntosTotales)
    {
        Puntos.text = puntosTotales.ToString();
    }

    public void DesactivarVida(int indice)
    {
        vidas[indice].SetActive(false);
    }

    public void ActivarVida(int indice)
    {
        vidas[indice].SetActive(true);
    }
}
