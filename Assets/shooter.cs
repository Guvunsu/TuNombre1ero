using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public GameObject SpawnObject;
    private Vector3 SpawnBullet = new Vector3  (0,0,0);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(SpawnObject,SpawnBullet, Quaternion.identity);
        }
    }
}
