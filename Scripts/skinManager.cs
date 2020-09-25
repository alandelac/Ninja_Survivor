using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skinManager : MonoBehaviour
{

    public enum Skin { Negro, Rojo, Verde, Blanco, Celeste, Naranja, Rosa, Amarillo, Morado, Basquet, Futbol};
    public Skin skinSelected;

    public Animator anim;
    public SpriteRenderer spriteRenderer;

    public RuntimeAnimatorController[] playersController;
    public Sprite[] playersRenderer;
    void Start()
    {
        switch (PlayerPrefs.GetString("SkinSelected", "NinjaNegro"))
        {
            case "NinjaNegro":
                spriteRenderer.sprite = playersRenderer[0];
                anim.runtimeAnimatorController = playersController[0];
                break;
            case "NinjaRojo":
                spriteRenderer.sprite = playersRenderer[1];
                anim.runtimeAnimatorController = playersController[1];
                break;
            case "NinjaVerde":
                spriteRenderer.sprite = playersRenderer[2];
                anim.runtimeAnimatorController = playersController[2];
                break;
            case "NinjaBlanco":
                spriteRenderer.sprite = playersRenderer[3];
                anim.runtimeAnimatorController = playersController[3];
                break;
            case "NinjaCeleste":
                spriteRenderer.sprite = playersRenderer[4];
                anim.runtimeAnimatorController = playersController[4];
                break;
            case "NinjaAmarillo":
                spriteRenderer.sprite = playersRenderer[5];
                anim.runtimeAnimatorController = playersController[5];
                break;
            case "Basquet":
                spriteRenderer.sprite = playersRenderer[6];
                anim.runtimeAnimatorController = playersController[6];
                break;
            case "Futbol":
                spriteRenderer.sprite = playersRenderer[7];
                anim.runtimeAnimatorController = playersController[7];
                break;
            case "NinjaMorado":
                spriteRenderer.sprite = playersRenderer[8];
                anim.runtimeAnimatorController = playersController[8];
                break;
            case "NinjaNaranja":
                spriteRenderer.sprite = playersRenderer[9];
                anim.runtimeAnimatorController = playersController[9];
                break;
            case "NinjaRosa":
                spriteRenderer.sprite = playersRenderer[10];
                anim.runtimeAnimatorController = playersController[10];
                break;
            default:
                break;
        }
    }

    
}
