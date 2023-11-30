using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoenemigo : MonoBehaviour
{
    public float MoveSpeed = 350;

    [SerializeField] private float cantidadPuntos;
    [SerializeField] private puntos puntuaje;

    void Start()
    {
        transform.Translate(Vector3.left.normalized * Time.deltaTime * MoveSpeed);
    }

    private void Update()
    {

    }
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        pos.x -= MoveSpeed * Time.fixedDeltaTime;
        transform.position = pos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            puntuaje.SumarPuntos(cantidadPuntos);
            Destroy(gameObject);
        }
    }
}

