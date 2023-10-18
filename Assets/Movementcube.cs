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
        objectToSpawn = transform.GetChild(0).gameObject;
        Debug.Log(objectToSpawn.name);
        
    }

    // Update is called once per frame
    void Update()
    {
       

        float dt = Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            direction.y = +1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction.y = -1;
        }
        transform.Find("objectToSpawn");
        transform.Translate(direction.normalized * dt * speed);
    }
}
