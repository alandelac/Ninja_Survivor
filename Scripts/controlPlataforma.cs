using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPlataforma : MonoBehaviour
{

    Rigidbody2D personaje;

    // Start is called before the first frame update
    void Start()
    {
        personaje = GameObject.Find("Personaje").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (personaje.gravityScale <0 )
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
