using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class controlVida : MonoBehaviour
{
    //Nuevo
    public GameObject personaje;
    AudioSource sonido;
    Vector2 actual;
    

    void Start()
    {
        actual = new Vector2(transform.position.x, transform.position.y);
        sonido = GetComponent<AudioSource>();
        DesaparecerItem();
        Invoke("ActivarItem", 25f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.Equals(personaje))
        {
            sonido.Play();
            personaje.GetComponent<InteraccionConAmbiente>().actualizarVida(50);
            DesaparecerItem();
            Invoke("ActivarItem", 40f);
        }
    }

    void DesaparecerItem()
    {
        transform.position = new Vector2(0, 5.5f);

    }

    void ActivarItem()
    {
        transform.position = actual;
    }
}
