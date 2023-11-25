using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class gun : MonoBehaviour
{
    public class bullet : MonoBehaviour
    {

        //www.youtube.com/watch?v=C7JRl9QoxIo}



        public bullet Bullet;
        Vector2 Direccion;

        public bool autoDisparo = false;
        public float disparoIntevaloSegundos = 0.5f;
        public float disparoDelaySegundos = 0.0f;
        float disparoTimer = 0f;
        float delayTimer = 0f;

        public float Daño = 1;

        void Start()
        {
            Shoot();
        }
        void Update()
        {
            Direccion = (transform.localRotation * Vector2.right).normalized;
            if (autoDisparo)
            {
                if (delayTimer >= disparoDelaySegundos)
                {
                    if (disparoTimer >= disparoIntevaloSegundos)
                    {
                        Shoot();
                        disparoTimer = 0;
                    }
                    else
                    {
                        disparoTimer += Time.deltaTime;
                    }
                }
                else
                {
                    delayTimer += Time.deltaTime;
                }
            }
        }
        public void Shoot()
        {
            GameObject go = Instantiate(Bullet.gameObject, transform.position, Quaternion.identity);
            bullet goBullet = go.GetComponent<bullet>();
            goBullet.Direccion = Direccion;
        }

    }

}
