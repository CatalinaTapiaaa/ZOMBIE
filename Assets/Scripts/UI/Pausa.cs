using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    public GameObject pausa;

    private bool juegoPausado = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            pausa.SetActive(true);
            if (juegoPausado)
            {
                Reanudar();
                Reiniciar();
                Lobby();
            }
        }
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        pausa.SetActive(false);
    }

    public void Reiniciar()
    {       
        Time.timeScale = 1f;
        SceneManager.LoadScene(3);
    }

    public void Lobby()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
    }
}
