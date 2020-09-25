using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem 
{
    public static void SavePlayer(controlMoneda monedas)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath+"/player.datos" ;
        FileStream stream = new FileStream(path, FileMode.Create);

        datosDelJugador datos = new datosDelJugador(monedas);

        formatter.Serialize(stream, datos);
        stream.Close();
    }

    public static datosDelJugador LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.datos";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            datosDelJugador datos=formatter.Deserialize(stream) as datosDelJugador;
            stream.Close();
            return datos;
        }
        else
        {
            Debug.LogError("Save file not found in "+path);
            return null;
        }
    }
}
