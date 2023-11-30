using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    //https://www.youtube.com/watch?v=nIfa2u5bU74
    public Slider VIdaSlider ;
    public int Vida = 0;
    public float Da�oEnemigo = 1;

    void Update()
    {
        Vida = 10;
        if (VIdaSlider.value <= 0)
        {
            Destroy( gameObject );
            Destroy(VIdaSlider);

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            VIdaSlider.value -= Da�oEnemigo;
            Destroy(collision.gameObject);


        }
    }
}
