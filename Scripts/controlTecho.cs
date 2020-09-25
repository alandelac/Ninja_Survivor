using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlTecho : MonoBehaviour
{
    ControlPersonaje personaje;
    void Start()
    {
        personaje = GameObject.Find("Personaje").GetComponent<ControlPersonaje>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Personaje"))
        {
            personaje.dejarDeSaltar();
        }
    }
}
