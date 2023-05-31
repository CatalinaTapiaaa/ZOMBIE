using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public Animator animator;

    [Header("Jugador")]
    [SerializeField] private float velocidad;
    [SerializeField] private float correr;
    bool estaDentro;

    Vector2 movimiento;

    void Update()
    {
        movimiento.x = Input.GetAxisRaw("Horizontal");
        movimiento.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movimiento.x);
        animator.SetFloat("Vertical", movimiento.y);
        animator.SetFloat("Movimiento", movimiento.sqrMagnitude);

    }

    void FixedUpdate()
    {
        if (estaDentro)
        {
            if (Input.GetKey(KeyCode.E))
            {
                rb2D.MovePosition(rb2D.position + movimiento * 0);
            }
            else
            {
                rb2D.MovePosition(rb2D.position + movimiento * velocidad * Time.fixedDeltaTime);
            }
        }
        if (!estaDentro)
        {
            rb2D.MovePosition(rb2D.position + movimiento * velocidad * Time.fixedDeltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Interactivo"))
        {
            estaDentro = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Interactivo"))
        {
            estaDentro = false;
        }
    }
}
