using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

public class bullet : MonoBehaviour
{
    public Vector3 direction;
    public float speed = 100f;
    private Rigidbody rb;
    public Vector3 bull= new Vector3(0, 2, 0);
    public GameObject Bullet;
    public GameObject Gun ;

    void Start()
    {    
    }

    void Update()
    {
        
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
        if (rb.velocity != Vector3.zero)
        { rb.velocity = rb.velocity * speed;   }

        
        float dt = Time.deltaTime;
        transform.Find("Gun");
        transform.transform.position = rb.position;
        transform.Translate ( direction.normalized * speed * Time.deltaTime );
    }
}
