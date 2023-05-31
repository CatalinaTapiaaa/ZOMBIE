using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton : MonoBehaviour
{
    public void Titulo()
    {
        SceneManager.LoadScene(0);
    }

    public void Lobby()
    {
        SceneManager.LoadScene(1);
    }

    public void Tutorial()
    {
        SceneManager.LoadScene(2);
    }

    public void Nivel1()
    {
        SceneManager.LoadScene(3);
    }

    public void Nivel2()
    {
        SceneManager.LoadScene(4);
    }


    public void Creditos()
    {
        SceneManager.LoadScene(5);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
