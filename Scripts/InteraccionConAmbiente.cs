using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Analytics;

public class InteraccionConAmbiente : MonoBehaviour
{

    public int energia = 100;
    Animator anim;
    public Text textoVida;
    public Slider sliderVida;
    public controlMoneda monedas;


    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void actualizarVida(int ptsVida)
    {
        if (energia + ptsVida > 100)
        {
            energia = 100;
        }
        else if (energia + ptsVida <= 0)
        {
            energia = 0;
            morir();
        }
        else
        {
            energia += ptsVida;
        }

        actualizarGUI();

    }

    public void lastimar(bool siONo)
    {
        anim.SetBool("Lastimar", siONo);
    }

    void morir()
    {
        anim.gameObject.GetComponent<ControlPersonaje>().enabled = false;
        int monedasAcomuladas = PlayerPrefs.GetInt("totalMonedas", 0) + monedas.puntos;
        PlayerPrefs.SetInt("totalMonedas", monedasAcomuladas);
        if (monedas.puntos > PlayerPrefs.GetInt("highscore", 0))
        {
            PlayerPrefs.SetInt("highscore", monedas.puntos);
        }
        
        ReportSurvivedTime();
        gameObject.SetActive(false);
    }

    void actualizarGUI()
    {
        textoVida.text = energia.ToString();
        sliderVida.value = energia;
    }

    public void ReportSurvivedTime()
    {
        Analytics.CustomEvent("Time_survived", new Dictionary<string, object>
        {
            { "time_elapsed", Time.timeSinceLevelLoad }
        });
    }

}
