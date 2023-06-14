using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad;
    public float destruirBala;
    float tiempo;

    void Update()
    {
        transform.position += transform.up * velocidad * Time.deltaTime;

        tiempo += Time.deltaTime;
        if(tiempo >= destruirBala)
        {
            Destroy(gameObject);
            tiempo = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
