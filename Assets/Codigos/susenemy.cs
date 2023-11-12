using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class susenemy : MonoBehaviour
// https://www.youtube.com/watch?v=ydjpNNA5804

{
    public GameObject Enemy;
    public int zPos;
    public int xPos;
    public int EnemyCount;
    public float Timer;

    void Start()
    {

        Timer = 1;
    }
    private void Update()
    {
        Timer = Timer - Time.deltaTime;
        if (Timer <= 1)
        {
            xPos = Random.Range(100, 0);
            zPos = Random.Range(0, 100);
            Instantiate(Enemy, new Vector3(xPos, 0, zPos), Quaternion.identity);
            Enemy.transform.position = new Vector3(xPos, zPos, 0);
            Timer = 2;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}

