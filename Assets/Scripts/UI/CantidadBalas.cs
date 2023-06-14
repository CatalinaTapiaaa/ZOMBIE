using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CantidadBalas : MonoBehaviour
{
    public float balas;
    private TextMeshProUGUI textMesh;

    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        textMesh.text = balas.ToString("0");
    }
}
