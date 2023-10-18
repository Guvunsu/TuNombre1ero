using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class susenemy : MonoBehaviour
{
    public GameObject Enemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        float time = 0;
        float numero = Random.Range(10, 20);
        Vector3 RandomPosition = new Vector3(10, numero, 20);
        if ( time <0)
        {
            Instantiate(Enemy, RandomPosition, Quaternion.identity);
        }
    }
}
