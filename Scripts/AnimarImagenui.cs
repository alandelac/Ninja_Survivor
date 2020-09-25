using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimarImagenui : MonoBehaviour
{

    public Image image;
    //public Sprite[] sprite;
    //public ControlPersonaje personaje;
    public SpriteRenderer spritePersonaje;
    //int energia;
   

    // Start is called before the first frame update
    void Start()
    {
       // energia = personaje.energy;
    }

    // Update is called once per frame
    void Update()
    {

        /* if (personaje.energy < energia)
         {
             image.sprite = sprite[1];
             energia = personaje.energy;
             Invoke("caraDefault", 2f);
         }
         else if (personaje.energy == 0)
         {
             image.sprite = sprite[2];
         }*/
        image.sprite = spritePersonaje.sprite;

    }

    void caraDefault()
    {
       // image.sprite = sprite[0];
    }

}
