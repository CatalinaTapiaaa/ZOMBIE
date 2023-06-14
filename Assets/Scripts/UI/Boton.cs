using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton : MonoBehaviour
{
    float tiempo;

    public void Introduccion()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void Titulo()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void Lobby()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }

    public void Tutorial()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;
    }

    public void Nivel1()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1f;
    }

    public void Nivel2()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1f;
    }


    public void Creditos()
    {
        SceneManager.LoadScene(6);
        Time.timeScale = 1f;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
