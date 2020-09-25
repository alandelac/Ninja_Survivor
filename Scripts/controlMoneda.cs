using UnityEngine;

using UnityEngine.UI;

public class controlMoneda : MonoBehaviour
{
    public GameObject personaje;
    public Text puntuacion;
    AudioSource sonido;
    public int puntos=0;
    public int puntosPorMoneda = 1;
    Vector2[] lugaresDeSpawn = new Vector2[8];
    int azar;

    // Start is called before the first frame update
    void Start()
    {
        puntosPorMoneda = PlayerPrefs.GetInt("ValorPuntos", 1);
        sonido = GetComponent<AudioSource>();
        lugaresDeSpawn[0] = new Vector2(-4.05f, -1.49f);
        lugaresDeSpawn[1] = new Vector2(-0.05f, -1.49f);
        lugaresDeSpawn[2] = new Vector2(4.24f, -1.49f);
        lugaresDeSpawn[3] = new Vector2(-2.01f, 0.05f);
        lugaresDeSpawn[4] = new Vector2(2.19f, 0.05f);
        lugaresDeSpawn[5] = new Vector2(-4.05f, 1.86f);
        lugaresDeSpawn[6] = new Vector2(-0.05f, 1.86f);
        lugaresDeSpawn[7] = new Vector2(4.24f, 1.86f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.Equals(personaje))
        {
            sonido.Play();
            puntos+=puntosPorMoneda;
            personaje.GetComponent<InteraccionConAmbiente>().actualizarVida(puntosPorMoneda);
            puntuacion.text = "Puntuacion: 0" + puntos;
            cambiarPosicion();
        }
    }

    void cambiarPosicion()
    {
        azar = UnityEngine.Random.Range(0, 7);
        gameObject.transform.position = new Vector3(lugaresDeSpawn[azar].x,lugaresDeSpawn[azar].y,0);
    }

}
