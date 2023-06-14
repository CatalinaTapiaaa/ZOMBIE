using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombies : MonoBehaviour
{
    public int cantidad;
    public Vector2 esquinaDerecha, esquinaIzquierda;

    public GameObject[] zombie;

    void Start()
    {
        for (int i = 0; i < cantidad; i++)
        {
            int ZombiesArrayIndex = Random.Range(0, zombie.Length);
            Vector2 pos = new Vector2(Random.Range(esquinaDerecha.x, esquinaIzquierda.x), Random.Range(esquinaDerecha.y, esquinaIzquierda.y));
            GameObject g = Instantiate(zombie[ZombiesArrayIndex], pos, Quaternion.identity);
        }
    }
}
