using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BulletEnemiga : MonoBehaviour
{
    public Vector2 direction = new Vector2(1, 0);
    public Vector2 Velocity;
    public float speed = 370;
    public float Daño = 1;
    void Start()
    {
        

    }

    void Update()
    {
        transform.Translate(Vector2.right.normalized * speed * Time.deltaTime);
        Velocity = direction * speed;
    }
    private void FixedUpdate()
    {

        Vector2  Pos = transform.position;
        Pos -= Velocity * Time.deltaTime;
        transform.position = Pos;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == ("Jugador"))
        {
           
            Destroy(gameObject);

        }
    }


}
