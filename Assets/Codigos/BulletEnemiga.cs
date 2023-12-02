using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BulletEnemiga : MonoBehaviour
{
    public Vector2 direction = new Vector2(1, 0);
    public Vector2 Velocity;
    public float speed = 370;
    //public bool shoot = true;

    public float Daño = 1;

    void Start()
    {
        transform.Translate(Vector2.left.normalized * speed * Time.deltaTime);
        Destroy(gameObject , 25);
    }

    void Update()
    {
        Velocity = direction * speed;
    }
    private void FixedUpdate()
    {

        // transform.Translate(Vector2.left.normalized * speed * Time.deltaTime);
        // if (shoot)
        //  {
        //     return;
        //  }
        //   else if (direction.x > 0);
        //  {
        //        direction.x += direction.x + speed + Time.deltaTime;
        //        return;
        //    }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            Destroy(gameObject);

        }
    }
}
