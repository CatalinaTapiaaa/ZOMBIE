using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLlave : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
        }
    }
}
