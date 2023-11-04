using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntos : MonoBehaviour
{
    
    private TMP_Text textComponent;
    private int puntuacion = 0;
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
}
