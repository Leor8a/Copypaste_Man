using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class MovimientoJugador : MonoBehaviour
{

    public float velocidad = 10, saltoMax = 3;
    public TMP_Text puntaje_UI;
    public string ganar, perder;
    public GameObject panel, UI_muerte;
    public bool saltando;
    public Animator anim; //Asignar desde editor

    private float timer, ingame, mov_h, mov_v;
    private int puntaje;

    Rigidbody rb;
    // Start is called before the first frame update
    bool pausa = false;

    Vector3 norm;


    //void Start() => rb = GetComponent<Rigidbody>();
    void Start()
    {
        panel = GameObject.FindWithTag("PanelPausa");
        UI_muerte = GameObject.FindWithTag("PausaMuerte");
        panel.SetActive(false);
        UI_muerte.SetActive(false);
        rb = GetComponent<Rigidbody>();
        Time.timeScale = 1;
    }
    //Intento corregir el error de cuando muere..
    private void FixedUpdate()
    {
        if (transform.position.y < -10f)
        {
            //Destroy(gameObject);
            morir();
        }
    }


    // Update is called once per frame
    void Update()
    {

        //SE IMPLEMENTA EL BOT?N DE PAUSA
        if (Input.GetButtonDown("Pause"))
        {
            pausar();
        }

        
        ingame = Time.deltaTime;
        timer += ingame; //Contador de salto
        mov_h = Input.GetAxis("Horizontal"); //movimiento en x
        mov_v = Input.GetAxis("Vertical");   // movimiento en z



        if (timer > 0.5f && Input.GetButtonDown("Jump"))
        {
            saltando = true;
            anim.SetBool("Saltando", saltando);
            rb.velocity = Vector3.up * saltoMax; //aumentamos y en 1
            FindObjectOfType<AudioManager>().Play("Jump");
            timer = 0.0f; //Regresamos timer a 0
        }

        //norm = new Vector3(mov_h * ingame * velocidad, rb.velocity.y * ingame, mov_v * ingame * velocidad);
        //transform.position += norm; 

        norm = Vector3.Normalize(new Vector3(mov_h, 0f, mov_v));
        transform.position += new Vector3(norm.x * velocidad, rb.velocity.y, norm.z * velocidad) * ingame;


    }


    void OnCollisionEnter(Collision colisionador)
    {

        if (colisionador.gameObject.tag == "Enemigo")
        {
            morir();
        }

        if (colisionador.gameObject.tag == "Ganar")
        {
            SceneManager.LoadScene(ganar);
        }

        if (colisionador.gameObject.tag == "Piso")
        {
            //puntaje += 1;
            saltando = false;
            FindObjectOfType<AudioManager>().Play("Land");
            anim.SetBool("Saltando", saltando);
            colisionador.gameObject.tag = "Pisado";
            puntaje++;
            ImprimirPuntaje();
        }
    }

    void ImprimirPuntaje() {
        string puntaje_text = "Score: " + puntaje.ToString();
        puntaje_UI.text = puntaje_text;
    }

    public void pausar(){

        if (pausa)
        {
            Time.timeScale = 1;
            panel.SetActive(false);
            pausa = false;
        }
        else
        {
            Time.timeScale = 0;
            panel.SetActive(true);
            pausa = true;
        }

    }

    void morir() {
        FindObjectOfType<AudioManager>().Play("Die");
        Time.timeScale = 0;
        UI_muerte.SetActive(true);
    }

    //public void reiniciar() => SceneManager.LoadScene(perder);
    public void reiniciar() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    public void salir() => Application.Quit();

}

