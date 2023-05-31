using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public Animator animator;

    [Header("Jugador")]
    [SerializeField] private float velocidad;
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
        rb2D.MovePosition(rb2D.position + movimiento * velocidad * Time.fixedDeltaTime);
    }
}
