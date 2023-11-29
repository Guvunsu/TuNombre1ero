using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructibles : MonoBehaviour
{
    public bool EstaActivo = false;
    bool CanSerDestroyed = false;

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
    public void OnTriggerEnter(Collider collision)
    {
        if (!CanSerDestroyed)
        {
            return;
        }
        bullet Bullet = collision.GetComponent<bullet>();
        if (Bullet != null)
        {
            if (Bullet != EstaActivo )
                {

            Destroy(gameObject);
            Destroy(Bullet.gameObject);
            }
        }

    }
}

