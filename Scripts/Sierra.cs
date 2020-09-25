using UnityEngine;

public class Sierra : MonoBehaviour
{
    bool izquierda = true;
    float x;
    public float azar;
    float primerCambio;
    public float limite;
    public GameObject Personaje;
    float velocidad;
    AudioSource sonido;

    // Start is called before the first frame update
    void Start()
    {
        sonido = GetComponent<AudioSource>();
        primerCambio = UnityEngine.Random.Range(10f, 20f);
        InvokeRepeating("cambioVelocidad", primerCambio,primerCambio);
    }

    // Update is called once per frame
    void Update()
    {
        velocidad = azar * Time.deltaTime;
        transform.position=new Vector3(velocidad+transform.position.x,transform.position.y,transform.position.z);
        x = transform.position.x;
        if(x<=limite*(-1) || x >= limite)
        {
            Flip( x);
        }
        rotar(velocidad);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.Equals(Personaje))
        {
            desactivarEnemigo();
            sonido.Play();
            Personaje.GetComponent<InteraccionConAmbiente>().actualizarVida(-20);
            Personaje.GetComponent<InteraccionConAmbiente>().lastimar(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.Equals(Personaje))
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            Invoke("activarEnemigo", 1.2f);
        }
    }

    void desactivarEnemigo()
    {
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
    }

    void activarEnemigo()
    {
        gameObject.GetComponent<CircleCollider2D>().enabled = true;
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }

    void Flip(float x)
    {
        if (x<0)
        {
            azar *= -1;
            x = limite*(-1)+0.01f;
            transform.position = new Vector3(x, transform.position.y, transform.position.z);
            izquierda = false;
        }
        if (x>0)
        {
            azar *= -1;
            x = limite-0.01f;
            transform.position = new Vector3(x, transform.position.y, transform.position.z);
            izquierda = true;
        }
    }

    void cambioVelocidad()
    {
        if (izquierda)
        {
            azar = UnityEngine.Random.Range(-7f, -2f);
        }
        if (!izquierda)
        {
            azar = UnityEngine.Random.Range(2f, 7f);
        }
    }

    void rotar(float v)
    {
        if (v < 0)
        {
            transform.Rotate(0, 0, 10);

        }
        if (v > 0)
        {
            transform.Rotate(0, 0, -10);
        }
    }
}
