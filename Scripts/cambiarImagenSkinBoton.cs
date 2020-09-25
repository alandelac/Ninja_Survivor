using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cambiarImagenSkinBoton : MonoBehaviour
{


    public Image spriteRenderer;

    public Sprite[] playersRenderer;
    void Start()
    {
        cambiarSkinBoton();
    }


    public void cambiarSkinBoton()
    {

        switch (PlayerPrefs.GetString("SkinSelected"))
        {
            case "NinjaNegro":
                spriteRenderer.sprite = playersRenderer[0];
                break;
            case "NinjaRojo":
                spriteRenderer.sprite = playersRenderer[1];
                break;
            case "NinjaVerde":
                spriteRenderer.sprite = playersRenderer[2];
                break;
            case "NinjaBlanco":
                spriteRenderer.sprite = playersRenderer[3];
                break;
            case "NinjaCeleste":
                spriteRenderer.sprite = playersRenderer[4];
                break;
            case "NinjaAmarillo":
                spriteRenderer.sprite = playersRenderer[5];
                break;
            case "NinjaNaranja":
                spriteRenderer.sprite = playersRenderer[6];
                break;
            case "NinjaRosa":
                spriteRenderer.sprite = playersRenderer[7];
                break;
            case "NinjaMorado":
                spriteRenderer.sprite = playersRenderer[8];
                break;
            case "Basquet":
                spriteRenderer.sprite = playersRenderer[9];
                break;
            case "Futbol":
                spriteRenderer.sprite = playersRenderer[10];
                break;
            default:
                break;
        }
    }
}
