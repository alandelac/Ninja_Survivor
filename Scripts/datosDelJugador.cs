using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class datosDelJugador 
{

    public int totalMonedas;
    public int recordMonedas;
   

    public datosDelJugador(controlMoneda monedasDePartida)
    {
        totalMonedas += monedasDePartida.puntos;
    }
}
