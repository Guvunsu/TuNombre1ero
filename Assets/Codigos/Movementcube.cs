using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;

public class Movementcube : MonoBehaviour
{


    public float DañoEnemigo = 0;
    public AudioSource AudioComponent;
    internal static int value;
    public float speed = 5f;
    public GameObject objectToSpawn;
   


    // Start is called before the first frame update
    void Start()
    {
        AudioComponent = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
            AudioComponent.Play();

        }

        float dt = Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up.normalized * dt * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down.normalized * dt * speed);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right.normalized * dt * speed);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left.normalized * dt * speed);

        }
        
    }
}
