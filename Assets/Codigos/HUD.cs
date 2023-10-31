using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour  //https://gist.github.com/RocketJamDev/a7c4d7d79964d08ad26a2befcb4baee2
{
    public TextMeshProUGUI puntos;
    public GameObject[] vidas;

    void Update()
    {
        puntos.text = gamemanager.Instance.PuntosTotales.ToString();
    }

    public void ActualizarPuntos(int puntosTotales)
    {
        puntos.text = puntosTotales.ToString();
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
