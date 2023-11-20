using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AngluosParaEnemigos : MonoBehaviour
{


    float sinCenterY;
    public float amplitud = 1;
    public float frecuency = 0.5f;

    public bool inverted = false;
    void Start()
    {
        sinCenterY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        float sin = Mathf.Sin(pos.x * frecuency) * amplitud;
        if ( inverted)
        {
            sin  *= -1;
        }
        pos.y = sinCenterY + sin;
        transform.position = pos;
    }
}
