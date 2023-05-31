using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipArma : MonoBehaviour
{
    private bool mirandoDerecha = true;

    private void Update()
    {
        Vector2 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        transform.rotation = rotation;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        if (mousePos.x > transform.position.x && !mirandoDerecha)
        {
            Girar();
        }
        else if (mousePos.x < transform.position.x && mirandoDerecha)
        {
            Girar();

        }
    }
    private void Girar()
    {
        mirandoDerecha = !mirandoDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }
}
