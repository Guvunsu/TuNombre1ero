using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class susenemy : MonoBehaviour
// https://www.youtube.com/watch?v=ydjpNNA5804

{
    public float Speed;
    public float yMax;
    public float yMin;
    private bool goesUp;

    public GameObject Enemy;
    public int yPos;
    public int EnemyCount;
    public float Timer;

    void Start()
    {

        Timer = 1;
    }
    private void Update()
    {
        SpitFire();

        if (transform.position.y > yMax)
        {
            goesUp = false;
        }
        if (transform.position.y < yMin)
        {
            goesUp = true;
        }

        if (goesUp == true)
        {
            transform.Translate(Vector3.up.normalized * Speed * Time.deltaTime);

        }
        else
        {
            transform.Translate(Vector3.down.normalized * Speed * Time.deltaTime);
        }

    }

    public void SpitFire()
    {
        Timer = Timer - Time.deltaTime;
        if (Timer <= 1)
        {
            yPos = Random.Range(100, 0);
            Instantiate(Enemy, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Timer = 2;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}

