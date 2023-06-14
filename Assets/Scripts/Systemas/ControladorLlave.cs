using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorLlave : MonoBehaviour
{
    public GameObject[] llave;
    public GameObject iconoLlave;

    void Update()
    {
        llave = GameObject.FindGameObjectsWithTag("Llave");

        if (llave.Length == 0)
        {
            iconoLlave.SetActive(true);
        }
    }
}
