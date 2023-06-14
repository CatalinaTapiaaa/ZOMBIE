using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieNormal : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agente;
    public int vida;

    [Header("DañoArma")]
    public int bala1;

    private void Start()
    {
        agente = GetComponent<NavMeshAgent>();
    }

    public void Update()
    {
        agente.SetDestination(player.position);

        if(vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bala1"))
        {
            vida -= bala1;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bala1"))
        {
            vida -= bala1;
        }
    }
}
