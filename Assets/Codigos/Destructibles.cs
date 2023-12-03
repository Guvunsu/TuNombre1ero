using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructibles : MonoBehaviour
{
    public bool EstaActivo = false;
    bool CanSerDestroyed = false;

    private float cantidadPuntos;
    private puntos puntuaje;

    void Start()
    {

    }


    void Update()
    {
        if (transform.position.x < 1932f && !CanSerDestroyed)
        {
            CanSerDestroyed = true;
            gun[] gun = transform.GetComponentsInChildren<gun>();
        }

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //if (CanSerDestroyed)
       // {
            if (collision.gameObject.tag == "Bala")
            {
                Destroy(gameObject);
            }
            if (collision.gameObject.tag == "Jugador")
            {
                Destroy(gameObject);
            }
          //  else
              //  CanSerDestroyed = false;

        //}
    }
}

