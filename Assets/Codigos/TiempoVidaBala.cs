using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoVidaBala : MonoBehaviour
{
    [SerializeField] private float TiempoVida;
    private void Start()
    {
        Destroy(gameObject, TiempoVida);
    }


}
