using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;

public class Movementcube : MonoBehaviour
{


    public float DañoEnemigo = 0;
    internal static int value;
    public float speed = 5f;
    public GameObject objectToSpawn;
   


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);

        }

        float dt = Time.deltaTime;
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.up.normalized * dt * speed);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.down.normalized * dt * speed);

        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.right.normalized * dt * speed);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.left.normalized * dt * speed);

        }
        
    }
}
