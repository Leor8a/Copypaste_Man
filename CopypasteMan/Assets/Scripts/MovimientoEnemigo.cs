using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    float velocidad;
    Vector3 posicion;

    // Start is called before the first frame update
    void Start()
    {
        velocidad = 3f;
        posicion = new Vector3(0.66f,0f,0.85f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
        transform.position += posicion * Time.deltaTime * velocidad;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "pared_ex")
        {
            posicion.x *= -1;
        }
        else if(col.gameObject.tag == "pared_ez")
        {
            posicion.z *= -1;
        }
    }
}
