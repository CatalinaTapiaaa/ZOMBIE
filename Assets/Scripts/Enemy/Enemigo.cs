using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour
{
    public Transform[] wakPoint;
    public NavMeshAgent agente;
    public Transform player;

    public float RadioMirar;
    public float tiempoDeEspera;
    public float timer;
    Vector3 target;
    public bool playerDetected;

    [Header("Movimiento")]
    private float movimiento;
    public float caminar;
    public float correr;


    void Start()
    {
        target = wakPoint[0].position;
        movimiento = agente.speed;
    }

    private void Update()
    {
        if(playerDetected == false)
        {
            CambiarTarget();
            movimiento = caminar;
        }
        else
        {
            target = player.position;
            movimiento = correr;
        }


        agente.SetDestination(target);
    }

    public void CambiarTarget()
    {
        timer += Time.deltaTime;
        if(timer >= tiempoDeEspera)
        {
            target = wakPoint[Random.Range(0, wakPoint.Length)].position;
            timer = 0;
        }
    }

}
