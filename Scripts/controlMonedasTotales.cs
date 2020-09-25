using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlMonedasTotales : MonoBehaviour
{

    int totalCoins;
    void Start()
    {
        SetScore();
    }
    public void SetScore()
    {
        totalCoins = PlayerPrefs.GetInt("totalMonedas", 0);
        gameObject.GetComponent<Text>().text = "x" + totalCoins;
    }

    public bool Gastar(int cantidad)
    {
        if(PlayerPrefs.GetInt("totalMonedas", 0) - cantidad >= 0)
        {
            cantidad = PlayerPrefs.GetInt("totalMonedas", 0) - cantidad;
            PlayerPrefs.SetInt("totalMonedas", cantidad);
            SetScore();
            return true;
        }
        else
        {
            return false;
        }
        

    }

    public void Recompensar(int cantidad)
    {
        UnityEngine.Debug.Log("Hola Mundo");
            cantidad = PlayerPrefs.GetInt("totalMonedas", 0) + cantidad;
            PlayerPrefs.SetInt("totalMonedas", cantidad);
            SetScore();
    }
}
