using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timepo : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    private float Tiempo = 0;



    //public GameObject[] vidas;



    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        Tiempo += Time.deltaTime;
        textMesh.text = Tiempo.ToString("Tiempo : 0");
    }



    public void SumarTiempo(int value)
    {
        Tiempo += Tiempo + value;
    }



    //  public void ActualizarPuntos(int puntosTotales)
    //    {
    //     Puntos.text = puntosTotales.ToString();
    //}

    /* public void DesactivarVida(int indice)
     {
         vidas[indice].SetActive(false);
     }

     public void ActivarVida(int indice)
     {
         vidas[indice].SetActive(true);
     }*/
}
