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

    // public bool isEnemy = false;

    public float Da�o = 1;

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
        Vector2 pos = transform.position;
        pos += Velocity * Time.deltaTime;
        transform.position = pos;
    }

    public void OnTriggerEnter2D(Collider2D enemigo)
    {
        if (enemigo.gameObject.tag == ("Untagged"))
        {
            Destroy(enemigo.gameObject);
            Destroy(gameObject);

        }
    }

}
