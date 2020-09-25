using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checarTienda : MonoBehaviour
{

    public controlBotones checar;
    // Start is called before the first frame update
    void Start()
    {
        checar.checarRojoShop();
        checar.checarBlancoShop();
        checar.checarVerdeShop();
        checar.checarCelesteShop();
        checar.checarAmarilloShop();
        checar.checarNaranjaShop();
        checar.checarRosaShop();
        checar.checarMoradoShop();
        checar.checarBasquetShop();
        checar.checarFutbolShop();
        checar.checarDobleShop();
    }

    
}
