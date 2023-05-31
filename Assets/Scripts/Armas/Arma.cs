using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public GameObject bala;
    public Transform puntero;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(bala, puntero.position, puntero.rotation);
        }
    }
}
