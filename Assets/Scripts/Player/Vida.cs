using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public int vida;

    [Header("DañoEnemigos")]
    public int zombieNormal;
    public int zombieRapido;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("ZombieNormal"))
        {
            vida -= zombieNormal;
        }

        if (other.CompareTag("ZombieRapido"))
        {
            vida -= zombieRapido;
        }
    }
}
