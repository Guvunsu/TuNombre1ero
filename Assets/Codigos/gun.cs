using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class gun : MonoBehaviour
{
    public bullet Bullet;
    Vector2 direction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = (transform.localRotation * Vector2.right).normalized;

    }
    public void Shoot()
    {
        GameObject go = Instantiate(Bullet.gameObject, transform.position, Quaternion.identity);
        bullet goBullet = go.GetComponent<bullet>();
        goBullet.direction = direction;

    }
}
