using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnHabitaciones : MonoBehaviour
{
    [SerializeField] private GameObject[] habitaciones;

    void Awake()
    {
        int h = Random.Range(0, habitaciones.Length);
        Instantiate(habitaciones[h], transform.position, Quaternion.identity);
    }
}