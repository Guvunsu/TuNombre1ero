using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    //https://www.youtube.com/watch?v=nIfa2u5bU74
    public Slider VIdaSlider;
    public float DañoEnemigo = 0;

    void Update()
    {
        if (VIdaSlider.value <= 0)
        {
            Destroy(gameObject);
            Destroy(VIdaSlider);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("SusEnemy")) ;
        VIdaSlider.value -= DañoEnemigo;
        Destroy(collision.gameObject);
    }
}
