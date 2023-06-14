using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public Player player;
    public Puntaje puntaje;
    public CantidadBalas cantidadBalas;

    [Header("Cambiar Armas")]
    public GameObject panel01;
    public GameObject panel02;
    public GameObject panel03;

    [Header("Daño a Jugador")]
    public int zombieNormal;

    [Header("Items Puntaje")]
    public int agua;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Arma 01"))
        {
            Time.timeScale = 0f;
            panel01.SetActive(true);
        }
        if (other.CompareTag("Arma 02"))
        {
            Time.timeScale = 0f;
            panel02.SetActive(true);
        }
        if (other.CompareTag("Arma 03"))
        {
            Time.timeScale = 0f;
            panel03.SetActive(true);
        }


        if (other.CompareTag("ZombieNormal"))
        {
            player.vida -= zombieNormal;
        }


        if (other.CompareTag("Agua"))
        {
            puntaje.puntaje += agua;
        }
    }
}
