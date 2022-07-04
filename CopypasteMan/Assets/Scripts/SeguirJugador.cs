using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    [SerializeField]
    Transform jugador;
    //GameObject jugador;
    Vector3 separacion = new Vector3(0f, 2f, -5f);
    public float x, y, sensiblidad = 1f;
    public short voltearEjes = -1;

    // Start is called before the first frame update
    /*
    
    void Start()
    {
        separacion = new Vector3(0f, 0f, -5f);
    }

    */

    void FixedUpdate()
    {
        x += voltearEjes * Input.GetAxis("Mouse X");
        y += -voltearEjes * Input.GetAxis("Mouse Y");
        y = Mathf.Clamp(y, 0f, 1f);
    }
    // Update is called once per frame
    // Fixed update, repara errores
    // Late Update, se ejecuta este al final antes que el de los enemigos
    void LateUpdate()
    {
        //transform.position = jugador.position + separacion;
        //LERP es la funcion que usamos para la interpolación vemos si si funciona
        //separacion = Vector3.Lerp(Vector3.zero, new Vector3(0f,50f,0f) , 0.6f);
        Quaternion rot = Quaternion.Euler(y * sensiblidad, x * sensiblidad, 0f);
        transform.position =  jugador.position + rot * separacion ;
        transform.LookAt(jugador);
    }
}
