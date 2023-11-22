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
        if (transform.position.x < 1910)
        {
          CanSerDestroyed  = true;
        }
        if ( transform.position.y < 62)
        {
            CanSerDestroyed = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        bullet Bullet = collision.GetComponent<bullet>();
        if (Bullet != null)
        {
            Destroy(gameObject);
            Destroy(Bullet.gameObject);
        }

    }
}
