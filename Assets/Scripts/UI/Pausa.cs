using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    public GameObject pausa;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausa.SetActive(true);
        }
    }
}
