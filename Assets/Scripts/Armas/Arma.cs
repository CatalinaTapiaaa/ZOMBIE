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

    void Start()
    {
        balasArma = GetComponent<CantidadBalas>().balas;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (balasArma >= 1)
            {
                Instantiate(bala, puntero.position, puntero.rotation);
                balasArma -= 1;
            }
        }
    }
}
