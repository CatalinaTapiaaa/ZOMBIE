using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPuntaje : MonoBehaviour
{
    public int cantidad;
    public GameObject[] allSpawns;

    void Awake()
    {
        allSpawns = GameObject.FindGameObjectsWithTag("Interactivo");
    }
    void Start()
    {
        for (int i = 0; i < cantidad; i++)
        {
            int s = Random.Range(0, allSpawns.Length);
            allSpawns[s].SetActive(false);
        }
    }
}

