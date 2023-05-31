using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaAtaque : MonoBehaviour
{
    public GameObject ataque;
    public float tiempoAtaque;

    public float tiempo;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Ataque();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ataque.SetActive(false);
        }
    }

    void Ataque()
    {
        tiempo += Time.deltaTime;
        ataque.SetActive(true);

        if (tiempo >= tiempoAtaque)
        {
            ataque.SetActive(false);
            Debug.Log("aaaaaaaaaa");
        }
    }
}
