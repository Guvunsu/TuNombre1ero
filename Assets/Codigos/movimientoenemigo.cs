using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoenemigo : MonoBehaviour
{
    public float MoveSpeed = 350;

    [SerializeField] public float cantidadPuntos;
    [SerializeField] public puntos puntuaje;

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
        if (collision.gameObject.tag == "Bala")
        {
            Destroy(gameObject);
        }
      
    }
}

