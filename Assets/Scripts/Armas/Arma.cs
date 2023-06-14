using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public CantidadBalas cantidadBalas;
    public GameObject bala;
    public Transform puntero;

    [Header("Sistema de Armas")]
    public float balasArma;
    public int tiempoEnfriamiento;
    float tiempo;

    private void Start()
    {
        tiempo = tiempoEnfriamiento;
    }

    void Update()
    {
        balasArma = cantidadBalas.balas;
        tiempo += Time.deltaTime;

        if (tiempo >= tiempoEnfriamiento)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (balasArma >= 1)
                {
                    tiempo = 0;
                    Instantiate(bala, puntero.position, puntero.rotation);
                    cantidadBalas.balas -= 1;
                }
            }
        }
    }
}
