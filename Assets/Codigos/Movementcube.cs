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
    [SerializeField] private float TiempoVida;
    int powerUpGunLevel = 0;
    


    void Start()
    {
        AudioComponent = GetComponent<AudioSource>();
        Armor = transform.Find("Armor").gameObject;
        DeactivateShield();
        guns = transform.GetComponentsInChildren<gun>();
        foreach (gun Gun in guns)
        {
                Gun.EstaActivo = true;
            if (Gun.powerUpLevelRequriment != 0 )
            {
                Gun.gameObject.SetActive(false);
            }
        }
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

    void ActivateShield()
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

    void AddGuns()
    {
        powerUpGunLevel++;
        foreach ( gun Gun in guns )
        {
            if ( Gun.powerUpLevelRequriment == powerUpGunLevel)
            {
                gun.gameObject.SetActive(true);
            }
        }
    }

    void IncreaseSpeed()
    {
        speed*=2;
    }

    public void OnTriggerEnter2D(Collider2D collision)
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
            if (HasShield())
            {
                DeactivateShield();
            }
            else
            {

                Destroy(gameObject);
            }
            Destroy(destructible.gameObject);
        }

        PowerUp powerUp = collision.GetComponent<PowerUp>();
        if (powerUp)
        {
            if (powerUp.activateShield)
            {
                ActivateShield();
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