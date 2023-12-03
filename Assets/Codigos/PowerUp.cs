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


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Jugador"))
        {
            PickUp(collision);
        }
    }
    void PickUp(Collider2D player)
    {
        if (player.CompareTag("Jugador"))
        {
            Destroy(gameObject);
            Instantiate(PickUpEffect, transform.position, Quaternion.identity);
            PickUp(player);
        }
    }
}
