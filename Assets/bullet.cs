using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

public class bullet : MonoBehaviour
{
    public float speed ;

    void Start()
    {    
    }

    void Update()
    {
        
    
        transform.Translate ( Vector3 .right.normalized * speed * Time.deltaTime );
    }
}
