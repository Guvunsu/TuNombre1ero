using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;

public class Movementcube : MonoBehaviour
{
    gun[] guns;

    public float DañoEnemigo = 1;
    internal static int value;
    public float speed = 200f;
    public GameObject RayoLaser;

    public AudioSource AudioComponent;
    [SerializeField] private float TiempoVida;

 

    void Start()
    {
        guns = transform.GetComponentsInChildren<gun>();
        AudioComponent = GetComponent<AudioSource>();
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(RayoLaser, transform.position, Quaternion.identity);
            Destroy(gameObject, TiempoVida);

          

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
    public void OnTriggerEnter2D(Collider2D collision)
    {
        bullet Bala = collision.GetComponent<bullet>();
        if (Bala != null)
        {
            Destroy(gameObject);
            Destroy(Bala.gameObject);
        }
    }
}
