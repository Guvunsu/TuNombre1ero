using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

public class bullet : MonoBehaviour
{
    [SerializeField] private float speed ;
    [SerializeField] private float Daño;

    void Start()
    {    
    }

    private void Update()
    {
        
    
        transform.Translate ( Vector2 .right.normalized * speed * Time.deltaTime );
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Enemigo"))
        {
            Destroy(gameObject);
        }
    }
   
}
