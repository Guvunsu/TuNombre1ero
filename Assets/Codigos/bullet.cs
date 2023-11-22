using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

public class bullet : MonoBehaviour
{
    public Vector2 direction = new Vector2(1, 0);
    public Vector2 Velocity;
    public float speed = 250;


    public float Daño = 1;

    void Start()
    {
        Destroy(gameObject, 3);
    }

    void Update()
    {
        Velocity = direction * speed;
    }
    private void FixedUpdate()
    {

        transform.Translate(Vector2.right.normalized * speed * Time.deltaTime);

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Enemigo"))
        {
            Destroy(gameObject);

        }
    }

}
