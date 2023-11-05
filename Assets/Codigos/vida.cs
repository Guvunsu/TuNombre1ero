using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida : MonoBehaviour   //https://gist.github.com/RocketJamDev/b24b1ba09fd94f6314d0f3d6b52bd608
{
    public GameOver gameManager;
    public float Vida;
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            bool vidaRecuperada = gamemanager.Instance.RecuperarVida();

            if (vidaRecuperada)
            {
                Destroy(this.gameObject);
            }
            if (Vida <= 0)
            {
                gameManager.gameOver();
            }
        }
    }
}
