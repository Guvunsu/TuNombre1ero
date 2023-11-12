using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

public class BulletEnemy : MonoBehaviour
{
    public float speed;

    void Start()
    {
    }

    void Update()
    {


        transform.Translate(Vector3.left.normalized * speed * Time.deltaTime);
    }
}