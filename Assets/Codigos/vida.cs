using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vida : MonoBehaviour   //https://gist.github.com/RocketJamDev/b24b1ba09fd94f6314d0f3d6b52bd608
{
    public GameOver gameManager;
    [SerializeField] int Vida;
    [SerializeField] int MaxVida;
    private bool siMuere; 
  
    private void Update()
    {
        Vida = MaxVida;
    }

    public void TomarDaño(int Daño)
    {
        Vida -= Daño;
        if ( Vida <= 0 )
        {
            Destroy(gameObject);
        }
    }

    public void Curar (int Curacion)
    {
        if (( Vida + Curacion) < MaxVida)
        {
            Vida = MaxVida;
        }
        else
        {
            Vida += Curacion;
        }


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
            if (Vida <= 0 && !siMuere)
            {
                siMuere = true;
                gameManager.gameOver();
            }
        }
    }
}
