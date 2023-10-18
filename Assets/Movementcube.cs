using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;

public class Movementcube : MonoBehaviour
{
   
    public float roospeed;
    public Vector3 direction = new Vector3(0, 0, 0);
    public float speed = 5f;
    public GameObject Gun;
    public GameObject Bullet;
    public GameObject objectToSpawn;
    public Transform SpawnPLaceholder;


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input .GetKeyDown(KeyCode.Space))
        {
        Instantiate(objectToSpawn, transform.position,Quaternion.identity);

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
       
    }
}
