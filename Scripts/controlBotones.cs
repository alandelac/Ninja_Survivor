using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class controlBotones : MonoBehaviour
{

    public GameObject panel;
    public cambiarImagenSkinBoton botonSkin;
    public GameObject rojo, verde, blanco, extraCoins, celeste, amarillo, naranja, rosa, basquet, futbol, morado,dobles;
    public controlMonedasTotales controlmonedas;
    public ControlMonetization ad;
    // Start is called before the first frame update
    public void cargarNivel()
    {
        SceneManager.LoadScene("Nivel 1");
        int contador = PlayerPrefs.GetInt("contador", 0);
        contador++;        
        if (contador == 4)
        {
            contador = 0;
            ad.InterstitialAd();
        }
        PlayerPrefs.SetInt("contador", contador);

    }

    public void cargarMenu()
    {
        SceneManager.LoadScene("Menu Principal");
    }

    public void cargarShop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void setNegro()
    {
        PlayerPrefs.SetString("SkinSelected", "NinjaNegro");
        desactivarPanel();
    }
    public void setRojo()
    {
        PlayerPrefs.SetString("SkinSelected", "NinjaRojo");
        desactivarPanel();
    }
    public void setVerde()
    {
        PlayerPrefs.SetString("SkinSelected", "NinjaVerde");
        desactivarPanel();
    }
    public void setBlanco()
    {
        PlayerPrefs.SetString("SkinSelected", "NinjaBlanco");
        desactivarPanel();
    }
    public void setCeleste()
    {
        PlayerPrefs.SetString("SkinSelected", "NinjaCeleste");
        desactivarPanel();
    }
    public void setAmarillo()
    {
        PlayerPrefs.SetString("SkinSelected", "NinjaAmarillo");
        desactivarPanel();
    }
    public void setNaranja()
    {
        PlayerPrefs.SetString("SkinSelected", "NinjaNaranja");
        desactivarPanel();
    }
    public void setRosa()
    {
        PlayerPrefs.SetString("SkinSelected", "NinjaRosa");
        desactivarPanel();
    }
    public void setBasquet()
    {
        PlayerPrefs.SetString("SkinSelected", "Basquet");
        desactivarPanel();
    }
    public void setFutbol()
    {
        PlayerPrefs.SetString("SkinSelected", "Futbol");
        desactivarPanel();
    }
    public void setMorado()
    {
        PlayerPrefs.SetString("SkinSelected", "NinjaMorado");
        desactivarPanel();
    }
    public void activarPanel()
    {
        panel.SetActive(true);
        checarRojoMenu();
        checarVerdeMenu();
        checarBlancoMenu();
        checarCelesteMenu();
        checarAmarilloMenu();
        checarNaranjaMenu();
        checarRosaMenu();
        checarMoradoMenu();
        checarBasquetMenu();
        checarFutbolMenu();
    }

    public void desactivarPanel()
    {
        panel.SetActive(false);
        botonSkin.cambiarSkinBoton();

    }

    void checarRojoMenu()
    {
        if (PlayerPrefs.GetString("HabilitarRojo").Equals("t"))
        {
            rojo.SetActive(true);
        }
        else
        {
            rojo.SetActive(false);
        }
    }
    void checarVerdeMenu()
    {
        if (PlayerPrefs.GetString("HabilitarVerde").Equals("t"))
        {
            verde.SetActive(true);
        }
        else
        {
            verde.SetActive(false);
        }
    }
    void checarBlancoMenu()
    {
        if (PlayerPrefs.GetString("HabilitarBlanco").Equals("t"))
        {
            blanco.SetActive(true);
        }
        else
        {
            blanco.SetActive(false);
        }
    }
    void checarCelesteMenu()
    {
        if (PlayerPrefs.GetString("HabilitarCeleste").Equals("t"))
        {
            celeste.SetActive(true);
        }
        else
        {
            celeste.SetActive(false);
        }
    }
    void checarAmarilloMenu()
    {
        if (PlayerPrefs.GetString("HabilitarAmarillo").Equals("t"))
        {
            amarillo.SetActive(true);
        }
        else
        {
            amarillo.SetActive(false);
        }
    }
    void checarNaranjaMenu()
    {
        if (PlayerPrefs.GetString("HabilitarNaranja").Equals("t"))
        {
            naranja.SetActive(true);
        }
        else
        {
            naranja.SetActive(false);
        }
    }
    void checarRosaMenu()
    {
        if (PlayerPrefs.GetString("HabilitarRosa").Equals("t"))
        {
            rosa.SetActive(true);
        }
        else
        {
            rosa.SetActive(false);
        }
    }
    void checarMoradoMenu()
    {
        if (PlayerPrefs.GetString("HabilitarMorado").Equals("t"))
        {
            morado.SetActive(true);
        }
        else
        {
            morado.SetActive(false);
        }
    }
    void checarBasquetMenu()
    {
        if (PlayerPrefs.GetString("HabilitarBasquet").Equals("t"))
        {
            basquet.SetActive(true);
        }
        else
        {
            basquet.SetActive(false);
        }
    }
    void checarFutbolMenu()
    {
        if (PlayerPrefs.GetString("HabilitarFutbol").Equals("t"))
        {
            futbol.SetActive(true);
        }
        else
        {
            futbol.SetActive(false);
        }
    }

    public void comprar(int costo)
    {
        bool adelante = controlmonedas.Gastar(costo);
        if (adelante)
        {
            switch (costo)
            {
                case 150:
                    PlayerPrefs.SetString("HabilitarNaranja", "t");
                    checarNaranjaShop();
                    break;
                case 200:
                    PlayerPrefs.SetString("HabilitarVerde", "t");
                    checarVerdeShop();
                    break;
                case 350:
                    PlayerPrefs.SetString("HabilitarAmarillo", "t");
                    checarAmarilloShop();
                    break;
                case 400:
                    PlayerPrefs.SetString("HabilitarRojo", "t");
                    checarRojoShop();
                    break;
                case 450:
                    PlayerPrefs.SetString("HabilitarRosa", "t");
                    checarRosaShop();
                    break;
                case 600:
                    PlayerPrefs.SetString("HabilitarCeleste", "t");
                    checarCelesteShop();
                    break;
                case 650:
                    PlayerPrefs.SetString("HabilitarMorado", "t");
                    checarMoradoShop();
                    break;
                case 1000:
                    PlayerPrefs.SetString("HabilitarBlanco", "t");
                    checarBlancoShop();
                    break;
                case 1200:
                    PlayerPrefs.SetInt("ValorPuntos", 2);
                    checarDobleShop();
                    break;
                case 1500:
                    PlayerPrefs.SetString("HabilitarBasquet", "t");
                    checarBasquetShop();
                    break;
                case 2000:
                    PlayerPrefs.SetString("HabilitarFutbol", "t");
                    checarFutbolShop();
                    break;

                default:
                    break;
            }
        }
       
    }

    public void checarRojoShop()
    {
        
        if (PlayerPrefs.GetString("HabilitarRojo").Equals("t"))
        {
            rojo.SetActive(false);
        }
        else
        {
            rojo.SetActive(true);
        }
    }
    public void checarVerdeShop()
    {
        if (PlayerPrefs.GetString("HabilitarVerde").Equals("t"))
        {
            verde.SetActive(false);            
        }
        else
        {
            
            verde.SetActive(true);
        }
    }
    public void checarBlancoShop()
    {
        if (PlayerPrefs.GetString("HabilitarBlanco").Equals("t"))
        {
            blanco.SetActive(false);
        }
        else
        {
            blanco.SetActive(true);
        }
    }
    public void checarCelesteShop()
    {

        if (PlayerPrefs.GetString("HabilitarCeleste").Equals("t"))
        {
            celeste.SetActive(false);
        }
        else
        {
            celeste.SetActive(true);
        }
    }
    public void checarAmarilloShop()
    {
        if (PlayerPrefs.GetString("HabilitarAmarillo").Equals("t"))
        {
            amarillo.SetActive(false);
        }
        else
        {
            amarillo.SetActive(true);
        }
    }
    public void checarNaranjaShop()
    {
        if (PlayerPrefs.GetString("HabilitarNaranja").Equals("t"))
        {
            naranja.SetActive(false);
        }
        else
        {
            naranja.SetActive(true);
        }
    }
    public void checarRosaShop()
    {

        if (PlayerPrefs.GetString("HabilitarRosa").Equals("t"))
        {
            rosa.SetActive(false);
        }
        else
        {
            rosa.SetActive(true);
        }
    }
    public void checarMoradoShop()
    {
        if (PlayerPrefs.GetString("HabilitarMorado").Equals("t"))
        {
            morado.SetActive(false);
        }
        else
        {

            morado.SetActive(true);
        }
    }
    public void checarBasquetShop()
    {
        if (PlayerPrefs.GetString("HabilitarBasquet").Equals("t"))
        {
            basquet.SetActive(false);
        }
        else
        {
            basquet.SetActive(true);
        }
    }
    public void checarFutbolShop()
    {
        if (PlayerPrefs.GetString("HabilitarFutbol").Equals("t"))
        {
            futbol.SetActive(false);
        }
        else
        {
            futbol.SetActive(true);
        }
    }
    public void checarDobleShop()
    {
        if (PlayerPrefs.GetInt("ValorPuntos")==2)
        {
            dobles.SetActive(false);
        }
        else
        {
            dobles.SetActive(true);
        }
    }

    public void deshabilitarExtraCoins()
    {
        extraCoins.SetActive(false);
    }

    public void resetear()
    {
        PlayerPrefs.DeleteAll();
    }
}
