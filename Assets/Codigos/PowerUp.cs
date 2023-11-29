using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public bool activateShield;
    public bool addGuns;
    public bool incrementarSpeed;
    public float multiplicador = 1.5f;
    public GameObject PickUpEffect;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PickUp(other);
        }
    }

    void PickUp(Collider player)
    {
        Instantiate(PickUpEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
