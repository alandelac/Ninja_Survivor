using System.IO.MemoryMappedFiles;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ControlPersonaje : MonoBehaviour
{
    //Para moverse
    Rigidbody2D rgb;
    bool isGnd = true; //Esta o no en el suelo?
    public float tiempoEnAire; //Tiempo que personaje sube en segundos
    public LayerMask ground;
    public int grv = -50; //velocidad con la que sube
    float h;
    public float velocidadMax; //velocidad en x
    float velocidadActual;
    Vector2 vel = new Vector2(0, 0);
    bool moveLeft;
    bool stop=true;
    bool permitirSalto=false;

    //Para las colisiones
    CircleCollider2D col;

    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        col = GetComponent<CircleCollider2D>();
    }
    void FixedUpdate()
    {
        
        isGnd = col.IsTouchingLayers(ground);

        moverseHorizontal();

        jump();

    }

    void rotar(float v)
    {
        if (v < 0)
        {
            transform.Rotate(0, 0, 15);
           
        }
        if (v > 0)
        {
            transform.Rotate(0, 0, -15);
        }
    }

    void moverseHorizontal()
    {
        if (Input.GetKey("left") || (moveLeft && !stop))
        {
            velocidadActual = -velocidadMax;
        }
        else if(Input.GetKey("right") || (!moveLeft && !stop))
        {
            velocidadActual = velocidadMax;
        }
        else
        {
            velocidadActual = 0;
        }
        
        vel.x = velocidadActual;
        rgb.velocity = vel;
        rotar(velocidadActual);
    }

    public void MoveMeUp()
    {
        permitirSalto = true;
    }

    public void StopJump()
    {
        permitirSalto = false;
    }
    void jump()
    {
        h = Input.GetAxisRaw("Vertical");

        if (h > 0 && isGnd || (isGnd && permitirSalto))
        {
            rgb.gravityScale = grv;
            Invoke("dejarDeSaltar", tiempoEnAire);
        }
    }

    public void dejarDeSaltar()
    {
        rgb.gravityScale = grv * (-1);
    }

    public void MoveMeLeft()
    {
        moveLeft = true;
        stop = false;
    }

    public void MoveMeRigth ()
    {
        moveLeft = false;
        stop = false;
    }
    public void StopMoving()
    {
        stop = true;
    }

   public void hola()
    {
        UnityEngine.Debug.Log("Hola Mundo");
    }

}
