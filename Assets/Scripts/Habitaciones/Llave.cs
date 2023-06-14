using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{
    public GameObject llave;
    private GameObject[] allSpawns;
    private int aleatorio;
    void Start()
    {
        allSpawns = GameObject.FindGameObjectsWithTag("Interactivo");
        aleatorio = Random.Range(0, allSpawns.Length);
        Instantiate(llave, allSpawns[aleatorio].transform.position, Quaternion.identity);
    }
}
