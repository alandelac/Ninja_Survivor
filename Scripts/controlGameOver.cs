using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlGameOver : MonoBehaviour
{
    public GameObject restart, menu, extraCoins;
    public Text gameOver;
    public InteraccionConAmbiente personaje;
    public bool yaLoVio = false;
    void Start()
    {
        restart.SetActive(false);
        menu.SetActive(false);
        extraCoins.SetActive(false);
        gameOver.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (personaje.energia <= 0)
        {
            restart.SetActive(true);
            menu.SetActive(true);
            if (!yaLoVio)
            {
                extraCoins.SetActive(true);
            }
            else
            {
                extraCoins.SetActive(false);
            }

            
            gameOver.enabled = true;
        }
    }
}
