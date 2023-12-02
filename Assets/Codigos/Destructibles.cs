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
        if (transform.position.x < 5090f && !CanSerDestroyed)
        {
            CanSerDestroyed = true;
            gun[] gun = transform.GetComponentsInChildren<gun>();
        }

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Bala")
        {
            Destroy(gameObject);
        }
    }
}

