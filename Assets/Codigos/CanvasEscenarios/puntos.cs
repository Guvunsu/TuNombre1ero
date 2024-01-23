using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntos : MonoBehaviour
{

   // private TMP_Text textComponent;
   // public TMP_Text Puntos;

    public float puntuacion = 0;
    private TextMeshProUGUI textMesh;

    // public GameObject[] vidas;

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
       
        puntuacion = Time.deltaTime;
        textMesh.text = puntuacion.ToString("Puntuacion : 0");
    }

  public void SumarPuntos(float puntosInicio)
    {
        puntuacion += puntosInicio;
    }



    /* public void ActualizarPuntos(int puntosTotales)
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
     }*/
}


