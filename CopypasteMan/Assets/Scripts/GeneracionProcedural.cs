using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneracionProcedural : MonoBehaviour
{
    [SerializeField]
    GameObject[] plano;
    float contador;
    Vector3 posicionDeseada;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(GameObject, Vector3, Quaternion);
        Instantiate(plano[0], Vector3.zero, Quaternion.identity);

    }

    void LateUpdate()
    {
        contador += Time.deltaTime;
        if (contador > 0.1f)
        {
            //posicionDeseada += Vector3.forward * 20f;
            posicionDeseada += new Vector3(Random.Range(-10f,10f), Random.Range(-2f, 2f), 20f);
            Instantiate(plano[(int)Random.Range(0,9)], posicionDeseada, Quaternion.identity);

            contador = 0;
        }
    }
}
