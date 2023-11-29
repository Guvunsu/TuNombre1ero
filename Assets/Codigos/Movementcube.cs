using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
//using UnityEditor.EditorTools;
using UnityEngine;

public class Movementcube : MonoBehaviour
{
    gun[] guns;



    GameObject Gun;
    GameObject Armor;
    public GameObject RayoLaser;

    public AudioSource AudioComponent;


    // internal static int value;
    public float DañoEnemigo = 1;
    public float speed = 200f;
    public float TiempoVida;


    int powerUpGunLevel = 0;
    public int powerUpLevelRequriment = 0;
    public bool EstaActivo = false;


    void Start()
    {
        AudioComponent = GetComponent<AudioSource>();
        //Armor = transform.Find("circle").gameObject;
        // this.Armor = Armor;
        //DeactivateShield();
        guns = transform.GetComponentsInChildren<gun>();

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(RayoLaser, transform.position, Quaternion.identity);
            //   foreach (gun Gun in guns)
            // {
            //  EstaActivo; Gun =false;
            //   if (gun.powerUpLevelRequriment != 0)
            // {
            //     Gun.gameObject.SetActive(false);
            //  }
            //}


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

    //los setactive/Desactive son para que se activen o al reves a un gameobject dependiendo de su resultado del valor de un booleano
    /* void ActivateShield()
     {
         Armor.SetActive(true);
     }
     void DeactivateShield()
     {
         Armor.SetActive(false);
     }
     bool HasShield()
     {
         return Armor.activeSelf;
     }
     */
    void AddGuns()
    {

        powerUpGunLevel++;

    }

    void IncreaseSpeed()
    {
        speed *= 2;
    }

    public void OnTriggerEnter(Collider collision)
    {

        bullet Bala = collision.GetComponent<bullet>();
        if (Bala != null)
        {
            Destroy(gameObject);
            Destroy(Bala.gameObject);
        }
        Destructibles destructible = collision.GetComponent<Destructibles>();
        if (destructible != null)
        {
            /*if (HasShield())
            {
                DeactivateShield();
            }
            else
            {

                Destroy(gameObject);
            }
            Destroy(destructible.gameObject);
        }
            */

            PowerUp powerUp = collision.GetComponent<PowerUp>();
            if (powerUp)
            {
                if (powerUp.activateShield)
                {
                    //ActivateShield();
                    if (powerUp.addGuns)
                    {
                        AddGuns();
                    }
                    if (powerUp.incrementarSpeed)
                    {
                        IncreaseSpeed();
                    }
                }
                Destroy(powerUp.gameObject);
            }
        }

    }
}