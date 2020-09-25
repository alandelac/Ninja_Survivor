using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class empezarNivel : MonoBehaviour
{

    public Text instrucciones;
    public String nivel;

    
    private void OnTriggerStay2D(Collider2D collision)
    {
        instrucciones.enabled = true;
        if (Input.GetKeyDown("e"))
        {
            cargarNivel();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        instrucciones.enabled = false;
    }

    public void cargarNivel()
    {
        SceneManager.LoadScene(nivel);
    }
}
