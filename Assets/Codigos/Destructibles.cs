using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructibles : MonoBehaviour
{

    bool CanSerDestroyed = false;

    void Start()
    {

    }


    void Update()
    {
        if (transform.position.x < 5090f)
        {
            CanSerDestroyed = true;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!CanSerDestroyed)
        {
            return;
        }
        bullet Bullet = collision.GetComponent<bullet>();
        if (Bullet != null)
        {
            Destroy(gameObject);
            Destroy(Bullet.gameObject);
        }

    }
}
