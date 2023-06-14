using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarArma : MonoBehaviour
{
    [Header("Paneles")]
    public GameObject panel01;
    public GameObject panel02;
    public GameObject panel03;

    [Header("Armas")]
    public GameObject arma01;
    public GameObject arma02;
    public GameObject arma03;

    public void Si01()
    {
        arma01.SetActive(true);
        arma02.SetActive(false);
        arma03.SetActive(false);

        Time.timeScale = 1f;
        panel01.SetActive(false);
    }
    public void No01()
    {
        Time.timeScale = 1f;
        panel01.SetActive(false);
    }

    public void Si02()
    {
        arma01.SetActive(false);
        arma02.SetActive(true);
        arma03.SetActive(false);

        Time.timeScale = 1f;
        panel02.SetActive(false);
    }
    public void No02()
    {
        Time.timeScale = 1f;
        panel02.SetActive(false);
    }

    public void Si03()
    {
        arma01.SetActive(false);
        arma02.SetActive(false);
        arma03.SetActive(true);

        Time.timeScale = 1f;
        panel03.SetActive(false);
    }
    public void No03()
    {
        Time.timeScale = 1f;
        panel03.SetActive(false);
    }
}
