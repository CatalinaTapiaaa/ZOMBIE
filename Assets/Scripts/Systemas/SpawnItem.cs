using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnItem : MonoBehaviour
{
    [Header("Barra de Carga")]
    public GameObject barra;
    public Transform barrita;
    public float tiempoDeCarga;
    bool estaDentro; 
    Vector3 escala;

    [Header("Spawn Items")]
    public GameObject[] items;
    private int aleatorio;

    void Start()
    {
        escala = new Vector3(0,1,1);
        barrita.localScale = escala;
        aleatorio = Random.Range(0, items.Length);
    }

    void Update()
    {
        if(estaDentro)
        {
            if (Input.GetKey(KeyCode.E))
            {
                barra.SetActive(true);

                escala.x += Time.deltaTime / tiempoDeCarga;
                escala.x = Mathf.Clamp(escala.x,0,1);
                barrita.localScale = escala;

                if(escala.x >= 1)
                {
                    Destroy(gameObject);
                    Instantiate(items[aleatorio], transform.position, transform.rotation);
                }
            }
            else
            {
                barra.SetActive(false);
                escala.x = Mathf.Clamp(escala.x, 0, 0);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            estaDentro = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            estaDentro = false;

        }
    }
}
