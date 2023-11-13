using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using TMPro;
public class Puntuacion : MonoBehaviour
{
    private float Puntos;

    private TMP_Text textMesh;
    private void Start()
    {
        textMesh = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        Puntos += Time.deltaTime;
        textMesh.text = Puntos.ToString();
    }
    public void SumarPuntos( float PuntosEntrada)
    {
        Puntos *= PuntosEntrada;
    }
}
