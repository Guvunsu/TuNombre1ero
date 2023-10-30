using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
   
    public GameObject objectToSpawn;
    public Vector3 spawnPoint = new Vector3(0, 0, 0);
    public Vector3 direction;
    public float speed = 100f;
    private Rigidbody rb;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        transform.Translate(direction.normalized * speed * Time.deltaTime);
        rb = GetComponent<Rigidbody>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Find("Gun");
            Instantiate(objectToSpawn, spawnPoint, Quaternion.identity);
        }

    }
}
