using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoenemigo : MonoBehaviour
{
    public float speed;
    private puntos Puntuacion;
    void Start()
    {
     
        Puntuacion = FindObjectOfType<puntos>();
    }

    private void Update()
    {
        transform.Translate(Vector3.left.normalized * speed * Time.deltaTime);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PLayer")
        {
        Puntuacion.AddPoints(1);
        Destroy(collision.gameObject);
        Destroy(gameObject);

        }



    }
}

